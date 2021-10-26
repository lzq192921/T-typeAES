// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.
// https://eprint.iacr.org/2019/833.pdf

namespace MaximovMixColumn
{
    open Microsoft.Quantum.Intrinsic;
    open QUtilities;


    // x: input
    // y: output
    operation MixColumn(in_state: Qubit[][], out_state: Qubit[][], first_word: Int, last_word: Int, costing: Bool) : Unit
    {
        body (...)
        {
            for (j in first_word..last_word)
            {
                MixWord(in_state[j], out_state[j], costing);
            }
        }
        adjoint auto;
    }

    // x: input
    // y: output
    operation MixWord (x: Qubit[], y: Qubit[], costing: Bool ) : Unit
    {
        body (...)
        {
           
            CNOTnBits(x[0..7], y[8..15], 8);
            CNOTnBits(x[8..15], y[0..7], 8);
            CNOTnBits(x[16..23], y[24..31], 8);
            CNOTnBits(x[24..31], y[16..23], 8);

            
            CNOTnBits(x[0..7], y[16..23], 8);
            CNOTnBits(x[8..15], y[24..31], 8);
            CNOTnBits(x[16..23], y[0..7], 8);
            CNOTnBits(x[24..31], y[8..15], 8);


            CNOTnBits(x[0..7], y[24..31], 8);
            CNOTnBits(x[8..15], y[16..23], 8);
            CNOTnBits(x[16..23], y[8..15], 8);
            CNOTnBits(x[24..31], y[0..7], 8);


            Mixbyte(x[0..7], costing);
            Mixbyte(x[8..15], costing);
            Mixbyte(x[16..23], costing);
            Mixbyte(x[24..31], costing);


            CNOTnBits(x[0..7], y[0..7], 8);
            CNOTnBits(x[8..15], y[8..15], 8);
            CNOTnBits(x[16..23], y[16..23], 8);
            CNOTnBits(x[24..31], y[24..31], 8);


            CNOTnBits(x[0..7], y[24..31], 8);
            CNOTnBits(x[8..15], y[0..7], 8);
            CNOTnBits(x[16..23], y[8..15], 8);
            CNOTnBits(x[24..31], y[16..23], 8);
           
        }
        adjoint auto;
    }



operation Mixbyte (x: Qubit[], costing: Bool) : Unit
    {
        body (...)
        {
            REWIRE(x[7], x[6], costing);
            REWIRE(x[6], x[5], costing);
            REWIRE(x[5], x[4], costing);
            REWIRE(x[4], x[3], costing);
            REWIRE(x[3], x[2], costing);
            REWIRE(x[2], x[1], costing);
            REWIRE(x[1], x[0], costing);
            CNOT(x[0], x[1]);
            CNOT(x[0], x[3]);
            CNOT(x[0], x[4]);
        }
        adjoint auto;
    }
}
