// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// https://www.nist.gov/publications/depth-16-circuit-aes-s-box

namespace Ttype
{
    open Microsoft.Quantum.Intrinsic;
    open QUtilities;

    // test "s-box" used to force T-depth n per round
    operation DummySBox(input: Qubit[], output: Qubit[], n: Int) : Unit
    {
        body (...)
        {
            for (i in 1..n)
            {
                T(input[0]);
                T(input[1]);
                T(input[2]);
                T(input[3]);
                T(input[4]);
                T(input[5]);
                T(input[6]);
                T(input[7]);

                T(output[0]);
                T(output[1]);
                T(output[2]);
                T(output[3]);
                T(output[4]);
                T(output[5]);
                T(output[6]);
                T(output[7]);

                CNOT(input[0], input[1]);
                CNOT(input[1], input[2]);
                CNOT(input[2], input[3]);
                CNOT(input[3], input[4]);
                CNOT(input[4], input[5]);
                CNOT(input[5], input[6]);
                CNOT(input[6], input[7]);
                CNOT(input[7], output[0]);
                CNOT(output[0], output[1]);
                CNOT(output[1], output[2]);
                CNOT(output[2], output[3]);
                CNOT(output[3], output[4]);
                CNOT(output[4], output[5]);
                CNOT(output[5], output[6]);
                CNOT(output[6], output[7]);
            }
        }
        adjoint auto;
    }


    operation SBox (input: Qubit[], output: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
            using((c, e, f, g, h, t) = (Qubit[12], Qubit[21], Qubit[8], Qubit[15], Qubit[15], Qubit[8]))
            {
             QGF256.Square(input, t, costing);
            inverse28(t, output, costing);
            QGF256.InPlace.SixtyFourth(output, costing);
            (Adjoint  QGF256.Square)(input, t, costing);
            X(output[0]);
            X(output[1]);
            X(output[5]);
            X(output[6]);
            }
        }
        adjoint auto;
    }

     operation SBox1 (input: Qubit[], output: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
            using((c, e, f, g, h, t) = (Qubit[12], Qubit[21], Qubit[8], Qubit[15], Qubit[15], Qubit[8]))
            {
             QGF256.Square(input, t, costing);
             (Adjoint QGF256.InPlace.SixtyFourth)(output, costing);
            inverse281(t, output, costing);
            QGF256.InPlace.SixtyFourth(output, costing);
            (Adjoint  QGF256.Square)(input, t, costing);
            X(output[0]);
            X(output[1]);
            X(output[5]);
            X(output[6]);
            }
        }
        adjoint auto;
    }

operation Mul(a : Qubit[], b: Qubit[], res: Qubit[], t: Qubit[], p: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
            LPXOR(a[0], a[1], t[0]);
            LPXOR(a[1], a[3], t[1]);
            LPXOR(a[2], a[0], t[2]);
            LPXOR(a[3], a[2], t[3]);
            LPXOR(t[0], t[3], t[4]);


            LPXOR(b[0], b[1], t[5]);
            LPXOR(b[1], b[3], t[6]);
            LPXOR(b[2], b[0], t[7]);
            LPXOR(b[3], b[2], t[8]);
            LPXOR(t[5], t[8], t[9]);


            LPAND(a[0], b[0], p[0], costing);
            LPAND(a[1], b[1], p[1], costing);                               //Fig.22
            LPAND(a[2], b[2], p[2], costing);
            LPAND(a[3], b[3], p[3], costing);
            LPAND(t[3], t[8], p[4], costing);   
            

            LPAND(t[1], t[6], res[0], costing); 
            LPAND(t[0], t[5], res[1], costing); 
            LPAND(t[2], t[7], res[2], costing); 
            LPAND(t[4], t[9], res[3], costing); 


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
        adjoint auto;
    }

operation Mull(a : Qubit[], b: Qubit[], res: Qubit[], t: Qubit[], p: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
            CNOT(res[0], res[1]);
            CNOT(res[1], res[3]);
            CNOT(res[2], res[3]);
            LPXOR(a[0], a[1], t[0]);
            LPXOR(a[1], a[3], t[1]);
            LPXOR(a[2], a[0], t[2]);
            LPXOR(a[3], a[2], t[3]);
            LPXOR(t[0], t[3], t[4]);


            LPXOR(b[0], b[1], t[5]);
            LPXOR(b[1], b[3], t[6]);
            LPXOR(b[2], b[0], t[7]);
            LPXOR(b[3], b[2], t[8]);
            LPXOR(t[5], t[8], t[9]);


            LPAND(a[0], b[0], p[0], costing);
            LPAND(a[1], b[1], p[1], costing);                               //Fig.23
            LPAND(a[2], b[2], p[2], costing);
            LPAND(a[3], b[3], p[3], costing);
            LPAND(t[3], t[8], p[4], costing);   
            

            LPAND(t[1], t[6], res[0], costing); 
            LPAND(t[0], t[5], res[1], costing); 
            LPAND(t[2], t[7], res[2], costing); 
            LPAND(t[4], t[9], res[3], costing); 


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
        adjoint auto;
    }



 operation ForwardMul(a : Qubit[], b: Qubit[], t: Qubit[], p: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
            LPXOR(a[0], a[1], t[0]);
            LPXOR(a[1], a[3], t[1]);
            LPXOR(a[2], a[0], t[2]);
            LPXOR(a[3], a[2], t[3]);
            LPXOR(t[0], t[3], t[4]);


            LPXOR(b[0], b[1], t[5]);
            LPXOR(b[1], b[3], t[6]);
            LPXOR(b[2], b[0], t[7]);
            LPXOR(b[3], b[2], t[8]);
            LPXOR(t[5], t[8], t[9]);


            LPAND(a[0], b[0], p[0], costing);
            LPAND(a[1], b[1], p[1], costing);                      //E in Fig.19 and Fig.20
            LPAND(a[2], b[2], p[2], costing);
            LPAND(a[3], b[3], p[3], costing);
            LPAND(t[3], t[8], p[4], costing);     
        }
        adjoint auto;
    }

    operation UnrolledMul(a : Qubit[], b: Qubit[], res: Qubit[], t: Qubit[], p: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
            LPXOR(a[0], a[1], t[0]);
            LPXOR(a[1], a[3], t[1]);
            LPXOR(a[2], a[0], t[2]);
            LPXOR(a[3], a[2], t[3]);
            LPXOR(t[0], t[3], t[4]);


            LPXOR(b[0], b[1], t[5]);
            LPXOR(b[1], b[3], t[6]);
            LPXOR(b[2], b[0], t[7]);
            LPXOR(b[3], b[2], t[8]);                                           
            LPXOR(t[5], t[8], t[9]);


            LPAND(a[3], b[3], res[0], costing);
            LPAND(a[0], b[0], res[1], costing);
            LPAND(t[3], t[8], res[2], costing);
            LPAND(a[2], b[2], res[3], costing);


            LPAND(a[1], b[1], p[0], costing);
            LPAND(t[0], t[5], p[1], costing);
            LPAND(t[1], t[6], p[2], costing);
            LPAND(t[2], t[7], p[3], costing);
            LPAND(t[4], t[9], p[4], costing);     

            LPXOR(res[2], p[2], p[1]);
            CNOT(res[1], p[0]);
            CNOT(p[0], p[3]);
            CNOT(p[3], res[2]);
            LPXOR(p[0], res[3], res[0]);                   ///Fig.21
            CNOT(p[1], res[1]);
            LPXOR(p[3], p[4], res[3]);
            CNOT(p[2], res[0]);
            CNOT(p[1], res[3]);
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
           CNOT(a[5], b[4]);                                         ///M^-1       Fig.11
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

   
    operation Inverse24(a: Qubit[], b: Qubit[], m: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
                // compute N
                LPXOR(a[0], a[3], a[2]);
                CNOT(a[1], a[3]);
                CNOT(a[2], a[1]);
                CNOT(a[1], a[3]);


                REWIRE(a[0], a[1], costing);
                REWIRE(a[0], a[3], costing);
                REWIRE(a[0], a[2], costing);


                CNOT(a[0], m[4]);
                CNOT(a[2], m[5]);
            

                LPAND(a[0], a[2], m[0], costing);
                LPAND(m[4], a[3], m[1], costing);
                LPAND(m[5], a[1], m[2], costing);                     ///inverse24       Fo           Fig.8
                CNOT(m[0], m[3]);  
                CNOT(a[1], a[0]);            
                CNOT(a[3], a[2]);
                CNOT(a[3], m[5]);


                
                CNOT(a[1], m[4]);
                CNOT(a[3], m[0]);
                CNOT(a[1], m[3]);


                LPAND(a[0], m[0], b[3], costing);
                LPAND(m[4], m[1], b[2], costing);
                LPAND(a[2], m[3], b[1], costing);
                LPAND(m[5], m[2], b[0], costing);
                CNOT(a[1], b[3]);
                CNOT(a[0], b[2]);
                CNOT(a[2], b[0]);
                CNOT(a[3], b[1]);            
                CNOT(a[3], m[0]);
                CNOT(m[0], b[0]);
                CNOT(m[0], b[2]);


                CNOT(b[1], b[2]);
                CNOT(b[0], b[3]);
                CNOT(b[3], b[2]);
                CNOT(b[1], b[0]);
                 CNOT(b[2], b[0]);


                REWIRE(b[0], b[1], costing);
                REWIRE(b[1], b[3], costing);
                REWIRE(b[2], b[3], costing);
        }
        adjoint auto;
    }

    operation inverse28(a: Qubit[], b: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
            using ((c, e, f, g, h) = (Qubit[12], Qubit[21], Qubit[8], Qubit[15], Qubit[15]))
            {
                  CNOTnBits(a[0..3], c[0..3], 4);
                CNOTnBits(a[4..7], c[4..7], 4);
                CNOTnBits(a[4..7], a[0..3], 4);
                UnrolledMul(a[0..3], c[0..3], c[8..11], e[0..9], e[10..14],  costing);
                InPlace.Square(c[4..7], costing);
                CNOTnBits(c[4..7], c[8..11], 4);
                Inverse24(c[8..11], f[0..3], e[15..20], costing);
                CNOTnBits(f[0..3], f[4..7], 4);
                Mul(a[0..3], f[0..3], b[0..3], g[0..9], g[10..14], costing);
                Mul(a[4..7], f[4..7], b[4..7], h[0..9], h[10..14], costing);                         ///Fig.19
               (Adjoint  ForwardMul)(a[0..3], f[0..3], g[0..9], g[10..14], costing);
                (Adjoint  ForwardMul)(a[4..7], f[4..7], h[0..9], h[10..14], costing);
                 CNOTnBits(f[0..3], f[4..7], 4);
                (Adjoint  Inverse24)(c[8..11], f[0..3], e[15..20], costing);
                CNOTnBits(c[4..7], c[8..11], 4);
                (Adjoint  InPlace.Square)(c[4..7], costing);
                (Adjoint UnrolledMul)(a[0..3], c[0..3], c[8..11], e[0..9], e[10..14],  costing);
                CNOTnBits(a[4..7], a[0..3], 4);
                 CNOTnBits(a[4..7], c[4..7], 4);
                 CNOTnBits(a[0..3], c[0..3], 4);                                    
            }
        }
        adjoint auto;
    }

operation inverse281(a: Qubit[], b: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
            using ((c, e, f, g, h) = (Qubit[12], Qubit[21], Qubit[8], Qubit[15], Qubit[15]))
            {
                  CNOTnBits(a[0..3], c[0..3], 4);
                CNOTnBits(a[4..7], c[4..7], 4);
                CNOTnBits(a[4..7], a[0..3], 4);
                UnrolledMul(a[0..3], c[0..3], c[8..11], e[0..9], e[10..14],  costing);
                InPlace.Square(c[4..7], costing);
                CNOTnBits(c[4..7], c[8..11], 4);
                Inverse24(c[8..11], f[0..3], e[15..20], costing);
                CNOTnBits(f[0..3], f[4..7], 4);
                Mull(a[0..3], f[0..3], b[0..3], g[0..9], g[10..14], costing);
                Mull(a[4..7], f[4..7], b[4..7], h[0..9], h[10..14], costing);                         ///Fig.20
               (Adjoint  ForwardMul)(a[0..3], f[0..3], g[0..9], g[10..14], costing);
                (Adjoint  ForwardMul)(a[4..7], f[4..7], h[0..9], h[10..14], costing);
                 CNOTnBits(f[0..3], f[4..7], 4);
                (Adjoint  Inverse24)(c[8..11], f[0..3], e[15..20], costing);
                CNOTnBits(c[4..7], c[8..11], 4);
                (Adjoint  InPlace.Square)(c[4..7], costing);
                (Adjoint UnrolledMul)(a[0..3], c[0..3], c[8..11], e[0..9], e[10..14],  costing);
                CNOTnBits(a[4..7], a[0..3], 4);
                 CNOTnBits(a[4..7], c[4..7], 4);
                 CNOTnBits(a[0..3], c[0..3], 4);                                    
            }
        }
        adjoint auto;
    }
}

namespace InPlace {
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


            REWIRE(a[0], a[1], costing);                               ///constant mul       Fig.9
            REWIRE(a[0], a[2], costing);
            REWIRE(a[2], a[3], costing);
        }
        adjoint auto;
    }

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
                                                       ///AM^-1            Fig.12
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
