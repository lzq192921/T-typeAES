// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
namespace QGF256
{
    open Microsoft.Quantum.Intrinsic;
    open QUtilities;

    /// <summary>
    /// Set res = a * b.
    /// Assumes output register to be Zeroed.
    /// </summary>
    /// <param name="a">Input register</param>
    /// <param name="b">Input register</param>
    /// <param name="res">Output register</param>
    /// <returns>Unit</returns>
    operation Mul(a : Qubit[], b: Qubit[], res: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
            using((t, m, p)=(Qubit[5], Qubit[5], Qubit[5]))
            {
            LPXOR(a[0], a[1], t[0]);
            LPXOR(a[1], a[3], t[1]);
            LPXOR(a[2], a[0], t[2]);
            LPXOR(a[3], a[2], t[3]);
            LPXOR(t[0], t[3], t[4]);


            LPXOR(b[0], b[1], m[0]);
            LPXOR(b[1], b[3], m[1]);
            LPXOR(b[2], b[0], m[2]);
            LPXOR(b[3], b[2], m[3]);
            LPXOR(m[0], m[3], m[4]);


            LPAND(a[0], b[0], p[0], costing);
            LPAND(a[1], b[1], p[1], costing);                               ///Mul2421
            LPAND(a[2], b[2], p[2], costing);
            LPAND(a[3], b[3], p[3], costing);
            LPAND(t[3], m[3], p[4], costing);   
            

            LPAND(t[1], m[1], res[0], costing); 
            LPAND(t[0], m[0], res[1], costing); 
            LPAND(t[2], m[2], res[2], costing); 
            LPAND(t[4], m[4], res[3], costing); 


            CNOT(p[0], res[0]);
            CNOT(p[4], res[2]);
            CNOT(res[1], res[3]);
            CNOT(res[0], res[1]);
            CNOT(res[2], res[3]);
            CNOT(p[1], res[0]);
            CNOT(p[4], res[1]);
            CNOT(p[0], res[2]);
            CNOT(p[1], res[2]);
            CNOT(p[2], res[0]);
            CNOT(res[0], res[3]);
            CNOT(p[3], res[0]); 
            }
        }
        adjoint auto;
    }

 operation ForwardMul(a : Qubit[], b: Qubit[], res: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
            using((t, m, p)=(Qubit[5], Qubit[5], Qubit[5]))
            {
            LPXOR(a[0], a[1], t[0]);
            LPXOR(a[1], a[3], t[1]);
            LPXOR(a[2], a[0], t[2]);
            LPXOR(a[3], a[2], t[3]);
            LPXOR(t[0], t[3], t[4]);


            LPXOR(b[0], b[1], m[0]);
            LPXOR(b[1], b[3], m[1]);
            LPXOR(b[2], b[0], m[2]);
            LPXOR(b[3], b[2], m[3]);
            LPXOR(m[0], m[3], m[4]);


            LPAND(a[0], b[0], p[0], costing);
            LPAND(a[1], b[1], p[1], costing);
            LPAND(a[2], b[2], p[2], costing);
            LPAND(a[3], b[3], p[3], costing);
            LPAND(t[3], m[3], p[4], costing);     
            }
        }
        adjoint auto;
    }




    /// <summary>
    /// Set res = a * b.
    /// Assumes output register to be Zeroed.
    /// Unrolled version.
    /// </summary>
    /// <param name="a">Input register</param>
    /// <param name="b">Input register</param>
    /// <param name="res">Output register</param>
    /// <returns>Unit</returns>
    operation UnrolledMul(a : Qubit[], b: Qubit[], res: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
             using((t, m, p)=(Qubit[5], Qubit[5], Qubit[5]))
            {
            LPXOR(a[0], a[1], t[0]);
            LPXOR(a[1], a[3], t[1]);
            LPXOR(a[2], a[0], t[2]);
            LPXOR(a[3], a[2], t[3]);
            LPXOR(t[0], t[3], t[4]);


            LPXOR(b[0], b[1], m[0]);
            LPXOR(b[1], b[3], m[1]);
            LPXOR(b[2], b[0], m[2]);
            LPXOR(b[3], b[2], m[3]);                                            ///Mul242
            LPXOR(m[0], m[3], m[4]);


            LPAND(a[3], b[3], res[0], costing);
            LPAND(a[0], b[0], res[1], costing);
            LPAND(t[3], m[3], res[2], costing);
            LPAND(a[2], b[2], res[3], costing);


            LPAND(a[1], b[1], p[0], costing);
            LPAND(t[0], m[0], p[1], costing);
            LPAND(t[1], m[1], p[2], costing);
            LPAND(t[2], m[2], p[3], costing);
            LPAND(t[4], m[4], p[4], costing);     ///与后面乘法相同部分

            LPXOR(res[2], p[2], p[1]);
            CNOT(res[1], p[0]);
            CNOT(p[0], p[3]);
            CNOT(p[3], res[2]);
            LPXOR(p[0], res[3], res[0]); 
            CNOT(p[1], res[1]);
            LPXOR(p[3], p[4], res[3]);
            CNOT(p[2], res[0]);
            CNOT(p[1], res[3]);
            }
        }
        adjoint auto;
    }

    
    operation Square(a: Qubit[], b: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
           CNOT(a[0], b[0]);
           CNOT(a[1], b[2]);
           CNOT(a[2], b[3]);
           CNOT(a[3], b[4]);
           CNOT(a[4], b[1]);
           CNOT(a[5], b[6]);
           CNOT(a[6], b[5]);
           CNOT(a[7], b[7]);

           CNOT(a[2], b[0]);
           CNOT(a[1], b[3]);
           CNOT(a[0], b[5]);
           CNOT(a[3], b[7]);
           CNOT(a[5], b[4]);
           CNOT(a[6], b[6]);


           CNOT(a[2], b[7]);
           CNOT(a[3], b[3]);
           CNOT(a[5], b[1]);
           CNOT(a[6], b[2]);

           CNOT(a[0], b[1]);
           CNOT(a[1], b[7]);
           CNOT(a[3], b[2]);

           CNOT(a[0], b[2]);
           CNOT(a[2], b[1]);
        }
        adjoint auto;
    }

    /// <summary>
    /// Computes b = a^4.
    /// Assumes output register to be Zeroed.
    /// </summary>
    /// <param name="a">Input register</param>
    /// <param name="b">Output register</param>
    /// <returns>Unit</returns>
    operation Inverse24(a: Qubit[], b: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
           using((q, m)=(Qubit[2], Qubit[4]))
            {
                // compute N
                LPXOR(a[0], a[3], a[2]);
                CNOT(a[3], a[1]);
                LPXOR(a[1], a[2], a[3]);
                CNOT(a[0], a[1]);


                REWIRE(a[0], a[1], costing);
                REWIRE(a[0], a[2], costing);

                CNOT(a[0], q[0]);
                CNOT(a[2], q[1]);
            

                LPAND(a[0], a[2], m[0], costing);
                LPAND(q[0], a[3], m[1], costing);
                LPAND(q[1], a[1], m[2], costing);                     ///inverse24       Fourth
                CNOT(m[0], m[3]);  
                CNOT(a[1], a[0]);            
                CNOT(a[3], a[2]);
                CNOT(a[3], q[1]);


                CNOT(m[3], b[0]);
                CNOT(a[1], q[0]);
                CNOT(m[0], b[2]);
                CNOT(a[3], m[0]);
                CNOT(a[1], m[3]);


                LPAND(a[0], m[0], b[3], costing);
                LPAND(q[0], m[1], b[2], costing);
                LPAND(a[2], m[3], b[1], costing);
                LPAND(q[1], m[2], b[0], costing);
                CNOT(a[1], b[3]);
                CNOT(a[0], b[2]);
                CNOT(a[2], b[0]);
                CNOT(a[3], m[1]);            ///中间部分


                CNOT(b[1], b[0]);
                LPXOR(b[2], b[0], b[3]);
                LPXNOR(b[1], b[3], b[2]);
                CNOT(b[3], b[0]);


                REWIRE(b[0], b[1], costing);
                REWIRE(b[1], b[2], costing);
            }
        }
        adjoint auto;
    }

    /// <summary>
    /// Computes b = a^16.
    /// Assumes output register to be Zeroed.
    /// </summary>
    /// <param name="a">Input register</param>
    /// <param name="b">Output register</param>
    /// <returns>Unit</returns>
    

    /// <summary>
    /// Computes b = 1/a.
    /// Assumes output register and ancillas to be Zeroed.
    /// </summary>
    /// <param name="a">Input register</param>
    /// <param name="b">Output register</param>
    /// <param name="c">Ancilla qubyte register</param>
    /// <param name="d">Ancilla qubyte register</param>
    /// <param name="e">Ancilla qubyte register</param>
    /// <returns>Unit</returns>
    operation Sixteenth(a: Qubit[], b: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
            using ((e, f, g, h, m) = (Qubit[4], Qubit[4], Qubit[4], Qubit[4], Qubit[4]))
            {
                 CNOTnBits(a[0..3], e, 4);
                CNOTnBits(a[4..7], f, 4);
                CNOTnBits(a[4..7], a[0..3], 4);
                UnrolledMul(a[0..3], e, g, costing);
                QGF256.InPlace.Square(f, costing);
                CNOTnBits(f, g, 4);
                Inverse24(g, h, costing);
                CNOTnBits(h, m, 4);
                Mul(a[0..3], h, b[0..3], costing);
                Mul(a[4..7], m, b[4..7], costing);                                            ///Inverse24
            }
        }
        adjoint auto;
    }
}

namespace QGF256.InPlace {
    open Microsoft.Quantum.Intrinsic;
    open QUtilities;

    /// <summary>
    /// Computes a^2 in place.
    /// </summary>
    /// <param name="a">Input/Output register</param>
    /// <returns>Unit</returns>
    operation Square(a: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
            CNOT(a[1], a[2]);
            CNOT(a[0], a[1]);
            CNOT(a[1], a[3]);


            REWIRE(a[0], a[1], costing);                               ///constant mul
            REWIRE(a[0], a[2], costing);
            REWIRE(a[2], a[3], costing);
        }
        adjoint auto;
    }

    /// <summary>
    /// Computes a^4 in place.
    /// </summary>
    /// <param name="a">Input/Output register</param>
    /// <returns>Unit</returns>
    operation Fourth(a: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
           CNOT(a[5], a[1]);
           CNOT(a[6], a[0]);

           CNOT(a[5], a[3]);
           CNOT(a[6], a[1]);

           CNOT(a[6], a[2]);

           CNOT(a[2], a[1]);
           CNOT(a[5], a[4]);


           CNOT(a[2], a[0]);
           CNOT(a[6], a[5]);
           CNOT(a[3], a[1]);


            CNOT(a[0], a[4]);
            CNOT(a[1], a[6]);

            CNOT(a[0], a[6]);
            CNOT(a[1], a[7]);
                                                
            CNOT(a[0], a[2]);


             REWIRE(a[1], a[3], costing);
             REWIRE(a[2], a[6], costing);
             REWIRE(a[1], a[4], costing);
             REWIRE(a[5], a[6], costing);
        }
        adjoint auto;
    }

    /// <summary>
    /// Computes a^64 in place.
    /// </summary>
    /// <param name="a">Input/Output register</param>
    /// <returns>Unit</returns>
    operation SixtyFourth(a: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
            CNOT(a[4], a[1]);
            CNOT(a[5], a[0]);
            CNOT(a[6], a[2]);

            CNOT(a[4], a[0]);
            CNOT(a[6], a[1]);
            CNOT(a[7], a[2]);


            CNOT(a[4], a[2]);
            CNOT(a[6], a[3]);
            CNOT(a[7], a[1]);

            CNOT(a[1], a[0]);
            CNOT(a[6], a[4]);

            CNOT(a[3], a[0]);
            CNOT(a[7], a[6]);
            CNOT(a[2], a[1]);
                                                       ///AM
            CNOT(a[3], a[2]);
            CNOT(a[1], a[7]);
            CNOT(a[0], a[4]);


            CNOT(a[0], a[7]);
            CNOT(a[1], a[4]);


            CNOT(a[0], a[6]);
            CNOT(a[1], a[5]);


            CNOT(a[0], a[3]);
            CNOT(a[5], a[7]);

            
            CNOT(a[0], a[1]);
            CNOT(a[2], a[3]);
            CNOT(a[4], a[5]);


             REWIRE(a[1], a[2], costing);
             REWIRE(a[2], a[3], costing);
             REWIRE(a[2], a[4], costing);
             REWIRE(a[4], a[6], costing);
             REWIRE(a[5], a[7], costing);
        }
        adjoint auto;
    }
}

