# Copyright (c) Microsoft Corporation.
# Licensed under the MIT license.
import qsharp
from gf256 import GF256Element, GF256Poly
import aes

# qsharp.reload()
# print(qsharp.get_available_operations())


class Tests:

    @staticmethod
    def test_SBox():
        from QTests.AES import SBox as SBox
        import numpy as np
        for _x in range(5):
            x = GF256Element(_x)
            y = GF256Element(1)
            sbox = GF256Element(aes.SBox(x))
            print("input_a:",x.coeffs)
            print("input_b:",y.coeffs)
            print("classical:",sbox.coeffs) #sbox
            qsbox = SBox.toffoli_simulate(_a=x.coeffs, tower_field=True, LPS19=True, costing=False) #sbox
            print("quantum:",qsbox)
            print('\n')
    
    @staticmethod
    def test_SBox1():
        from QTests.AES import SBox1_test as SBox1
        import numpy as np
        for _x in range(5):
            x = GF256Element(_x)
            y = GF256Element(1)
            sbox = GF256Element(aes.SBox(x))
            print("input_a:",x.coeffs)
            print("input_b:",y.coeffs)

            print("classical_SBox1:", np.bitwise_xor(sbox.coeffs, y.coeffs)) #test_sbox1
            qsbox = SBox1.toffoli_simulate(_a=x.coeffs, _b=y.coeffs, tower_field=True, LPS19=True, costing=False) #test_sbox1
            print("quantum_SBox1:",qsbox)
            print('\n')

    @staticmethod
    def test_keyExpansion():
        from random import randint
        in_place = True
        Nr=10
        Nk=4
        if in_place:
            from QTests.AES import InPlaceKeyExpansion as KeyExpansion # pylint: disable=no-name-in-module,import-error
        else:
            from QTests.AES import KeyExpansion # pylint: disable=no-name-in-module,import-error
        def bits_to_int(bits):
            return sum([1 << i if bits[i] == 1 else 0 for i in range(8)])    
        key = {'Nb': 4, 'Nk': Nk, 'k': [ [randint(0, 255) for i in range(4)] for j in range(Nk)]}
        qkey = [GF256Element(key['k'][j][i]).coeffs for j in range(Nk) for i in range(4)]
        qkey = [e for sub in qkey for e in sub]
        
        key = aes.KeyExpansion(key, Nr)
        qkey = KeyExpansion.toffoli_simulate(_key=qkey, Nr=Nr, Nk=Nk, costing=False)
        qkey = [bits_to_int(qkey[i*8:(i+1)*8]) for i in range(len(qkey)//8)]
        qkey = [qkey[i*4:(i+1)*4] for i in range(len(qkey)//4)]
        qkey = [qkey[i*4:(i+1)*4] for i in range(len(qkey)//4)]
        print('classical:', key)
        print('quantum:', qkey)
        
    


# if __name__ == "__main__":
#     import doctest
#     doctest.testmod()

if __name__ == "__main__":
    
    print("Test SBox:")
    Tests.test_SBox()
    print("Test SBox1:")
    Tests.test_SBox1()
    print("Test keyExpansion:")
    Tests.test_keyExpansion()
    
    # a = [0,0,0,1]
    # b= [0,0,0,1]
    # res= [0,0,0,0]
    # from QTests.Test import Mull as Mull
    # from QTests.Test import Mul as Mul
    # res_Mull = Mull(_a=a, _b=b, _res=res, _t=[0], _p=[0], costing=False)
    # res_Mul = Mul(_a=a, _b=b, _res=res, _t=[0], _p=[0], costing=False)
    # print("res_Mull:",res_Mull)
    # print("res_Mul:",res_Mul)

    # from QTests.AES import SBox1 as SBox
    # for _x in range(5):
    #     x = GF256Element(_x)
    #     print(SBox.estimate_resources(_a=x.coeffs, tower_field=True, LPS19=True, costing=True))