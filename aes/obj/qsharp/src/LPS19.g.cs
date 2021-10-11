#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"LPS19\",\"Name\":\"ForwardSBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/LPS19.qs\",\"Position\":{\"Item1\":9,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"u\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"t\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"z\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"s\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":61}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":72},\"Item2\":{\"Line\":1,\"Column\":79}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"LPS19\",\"Name\":\"ForwardSBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/LPS19.qs\",\"Position\":{\"Item1\":11,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"LPS19\",\"Name\":\"ForwardSBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/LPS19.qs\",\"Position\":{\"Item1\":353,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"LPS19\",\"Name\":\"SBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/LPS19.qs\",\"Position\":{\"Item1\":356,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"output\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"LPS19\",\"Name\":\"SBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/LPS19.qs\",\"Position\":{\"Item1\":358,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"LPS19\",\"Name\":\"SBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/LPS19.qs\",\"Position\":{\"Item1\":374,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace LPS19
{
    public partial class ForwardSBox : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public ForwardSBox(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "ForwardSBox";
        String ICallable.FullName => "LPS19.ForwardSBox";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit,Boolean)> QUtilitiesLPAND
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (u,t,z,s,costing) = __in__;
#line 14 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[5L]));
#line 15 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[5L]));
#line 16 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[6L], u[5L]));
#line 17 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[4L]));
#line 18 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[4L]));
#line 19 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[6L], u[4L]));
#line 20 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((u[5L], u[4L], t[0L], costing));
#line 21 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[0L], t[5L]));
#line 23 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[3L]));
#line 24 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[3L]));
#line 25 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[7L], u[3L]));
#line 26 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((u[3L], u[7L], t[0L], costing));
#line 28 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[6L]));
#line 29 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[2L]));
#line 30 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[4L], u[2L]));
#line 31 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[5L], u[2L]));
#line 32 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[6L], u[2L]));
#line 33 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((u[6L], u[2L], t[1L], costing));
#line 34 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[1L], t[2L]));
#line 36 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[1L]));
#line 37 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[4L], u[1L]));
#line 38 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[5L], u[1L]));
#line 39 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[7L], u[1L]));
#line 40 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[0L]));
#line 41 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[6L], u[0L]));
#line 42 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((u[1L], u[0L], t[1L], costing));
#line 44 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[6L]));
#line 45 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[2L]));
#line 46 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((u[6L], u[2L], t[2L], costing));
#line 48 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[6L], u[3L]));
#line 49 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[7L], u[2L]));
#line 50 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((u[3L], u[2L], t[3L], costing));
#line 51 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[3L], t[4L]));
#line 53 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[6L]));
#line 54 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[5L], u[6L]));
#line 55 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[0L]));
#line 56 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[4L], u[0L]));
#line 57 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[7L], u[0L]));
#line 58 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((u[6L], u[0L], t[3L], costing));
#line 60 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[6L], u[3L]));
#line 61 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[0L]));
#line 62 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((u[3L], u[0L], t[4L], costing));
#line 64 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[3L], t[1L]));
#line 66 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[3L]));
#line 67 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[7L], u[4L]));
#line 68 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((u[3L], u[4L], t[5L], costing));
#line 70 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[5L], t[3L]));
#line 72 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[4L], t[0L]));
#line 74 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[2L], t[4L]));
#line 76 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[6L]));
#line 77 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[6L]));
#line 78 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[6L]));
#line 79 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[6L], t[3L]));
#line 81 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[1L]));
#line 82 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[1L]));
#line 83 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], t[0L]));
#line 85 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[5L]));
#line 86 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[4L], u[5L]));
#line 87 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[6L], u[5L]));
#line 88 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[7L], u[5L]));
#line 89 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[5L], t[1L]));
#line 91 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[4L]));
#line 92 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[4L]));
#line 93 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[5L], u[4L]));
#line 94 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[4L], t[4L]));
#line 96 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[3L], t[1L], t[6L], costing));
#line 97 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[0L], t[3L]));
#line 99 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[4L], t[7L]));
#line 100 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[6L], t[7L]));
#line 102 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[0L], t[6L]));
#line 103 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[3L], t[7L], t[0L], costing));
#line 105 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[1L], t[8L]));
#line 106 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[4L], t[8L]));
#line 108 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[6L], t[8L], t[9L], costing));
#line 111 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[4L], t[8L]));
#line 112 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[1L], t[8L]));
#line 115 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[4L], t[9L]));
#line 116 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[9L], t[1L]));
#line 118 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[7L], t[8L]));
#line 119 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[9L], t[8L]));
#line 121 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[4L], t[8L], t[10L], costing));
#line 124 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[9L], t[8L]));
#line 125 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[7L], t[8L]));
#line 128 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[10L], t[1L]));
#line 129 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[10L], t[7L]));
#line 130 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[0L], t[7L], t[3L], costing));
#line 132 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[3L], t[8L]));
#line 133 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[1L], t[8L]));
#line 135 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[0L], t[11L]));
#line 136 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[9L], t[11L]));
#line 139 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[0L], t[12L]));
#line 140 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[3L], t[12L]));
#line 142 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[9L], t[13L]));
#line 143 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[1L], t[13L]));
#line 145 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[11L], t[14L]));
#line 146 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((t[8L], t[14L]));
#line 148 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[2L]));
#line 149 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[2L]));
#line 150 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[6L], u[2L]));
#line 152 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[4L]));
#line 153 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[4L]));
#line 154 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[5L], u[4L]));
#line 156 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[6L]));
#line 157 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[6L]));
#line 158 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[4L], u[6L]));
#line 159 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[5L], u[6L]));
#line 160 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[7L], u[6L]));
#line 162 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[0L]));
#line 163 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[0L]));
#line 165 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[3L]));
#line 166 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[3L]));
#line 167 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[6L], u[3L]));
#line 169 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[0L], u[3L], s[2L], costing));
#line 170 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[2L], s[5L]));
#line 172 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[3L]));
#line 173 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[12L], u[3L], s[6L], costing));
#line 174 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[6L], s[2L]));
#line 175 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[6L], s[5L]));
#line 176 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[3L]));
#line 178 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[1L], u[4L], s[1L], costing));
#line 179 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[1L], s[3L]));
#line 180 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[1L], s[4L]));
#line 181 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[7L], u[4L]));
#line 182 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[13L], u[4L], s[7L], costing));
#line 183 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[7L], s[1L]));
#line 184 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[7L], s[2L]));
#line 185 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[7L], s[3L]));
#line 186 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[7L], s[5L]));
#line 187 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[7L], u[4L]));
#line 189 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[3L], u[0L], s[6L], costing));
#line 190 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[6L], s[7L]));
#line 192 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[6L]));
#line 193 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[11L], u[6L], s[0L], costing));
#line 194 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[0L], s[2L]));
#line 195 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[6L]));
#line 197 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[14L], u[2L], s[0L], costing));
#line 198 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[0L], s[1L]));
#line 199 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[0L], s[3L]));
#line 200 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[0L], s[4L]));
#line 201 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[0L], s[5L]));
#line 202 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[0L], s[6L]));
#line 203 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((s[0L], s[7L]));
#line 205 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[9L], u[7L], z[0L], costing));
#line 206 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[2L]));
#line 207 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[4L]));
#line 208 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[5L]));
#line 209 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[7L]));
#line 210 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[9L], u[7L], z[0L], costing));
#line 212 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[5L]));
#line 213 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[5L]));
#line 214 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[12L], u[5L], z[0L], costing));
#line 216 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[0L]));
#line 217 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[3L]));
#line 218 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[5L]));
#line 219 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[7L]));
#line 221 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[12L], u[5L], z[0L], costing));
#line 222 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[5L]));
#line 223 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[5L]));
#line 225 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[6L]));
#line 226 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[6L]));
#line 227 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[6L]));
#line 228 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[4L], u[6L]));
#line 229 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[3L], u[6L], z[0L], costing));
#line 231 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[0L]));
#line 232 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[3L]));
#line 233 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[4L]));
#line 234 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[5L]));
#line 235 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[6L]));
#line 237 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[3L], u[6L], z[0L], costing));
#line 238 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[4L], u[6L]));
#line 239 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[6L]));
#line 240 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[6L]));
#line 241 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[6L]));
#line 243 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[6L]));
#line 244 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[6L]));
#line 245 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[6L]));
#line 246 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[4L], u[6L]));
#line 247 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[5L], u[6L]));
#line 248 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[0L], u[6L], z[0L], costing));
#line 250 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[4L]));
#line 251 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[6L]));
#line 252 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[7L]));
#line 254 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[0L], u[6L], z[0L], costing));
#line 255 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[5L], u[6L]));
#line 256 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[4L], u[6L]));
#line 257 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[6L]));
#line 258 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[6L]));
#line 259 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[6L]));
#line 261 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[7L]));
#line 262 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[7L]));
#line 263 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[7L]));
#line 264 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[4L], u[7L]));
#line 265 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[5L], u[7L]));
#line 266 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[6L], u[7L]));
#line 267 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[11L], u[7L], z[0L], costing));
#line 269 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[0L]));
#line 270 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[1L]));
#line 271 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[2L]));
#line 273 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[11L], u[7L], z[0L], costing));
#line 274 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[6L], u[7L]));
#line 275 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[5L], u[7L]));
#line 276 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[4L], u[7L]));
#line 277 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[7L]));
#line 278 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[7L]));
#line 279 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[7L]));
#line 281 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[7L]));
#line 282 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[7L]));
#line 283 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[4L], u[7L]));
#line 284 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[5L], u[7L]));
#line 285 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[14L], u[7L], z[0L], costing));
#line 287 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[0L]));
#line 288 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[1L]));
#line 289 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[5L]));
#line 290 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[6L]));
#line 292 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[14L], u[7L], z[0L], costing));
#line 293 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[5L], u[7L]));
#line 294 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[4L], u[7L]));
#line 295 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[7L]));
#line 296 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[7L]));
#line 298 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[6L]));
#line 299 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[6L]));
#line 300 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[6L]));
#line 301 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[8L], u[6L], z[0L], costing));
#line 303 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[2L]));
#line 304 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[5L]));
#line 305 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[6L]));
#line 307 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[8L], u[6L], z[0L], costing));
#line 308 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[6L]));
#line 309 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[6L]));
#line 310 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[1L], u[6L]));
#line 312 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[3L]));
#line 313 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[3L]));
#line 314 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[13L], u[3L], z[0L], costing));
#line 316 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[0L]));
#line 317 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[1L]));
#line 318 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[3L]));
#line 319 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[4L]));
#line 321 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[13L], u[3L], z[0L], costing));
#line 322 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[3L]));
#line 323 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[3L]));
#line 325 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[6L]));
#line 326 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[6L]));
#line 327 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[6L]));
#line 328 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[1L], u[6L], z[0L], costing));
#line 330 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[0L]));
#line 331 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[1L]));
#line 332 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[3L]));
#line 333 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[4L]));
#line 334 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((z[0L], s[5L]));
#line 336 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[1L], u[6L], z[0L], costing));
#line 337 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[6L]));
#line 338 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[6L]));
#line 339 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[0L], u[6L]));
#line 341 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[6L]));
#line 342 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[6L]));
#line 343 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[8L], u[6L], s[2L], costing));
#line 344 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[3L], u[6L]));
#line 345 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((u[2L], u[6L]));
#line 347 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            QUtilitiesLPAND.Apply((t[9L], u[6L], s[5L], costing));
#line 349 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicX.Apply(s[1L]);
#line 350 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicX.Apply(s[2L]);
#line 351 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicX.Apply(s[6L]);
#line 352 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
            MicrosoftQuantumIntrinsicX.Apply(s[7L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (u,t,z,s,costing) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(s[7L]);
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(s[6L]);
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(s[2L]);
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(s[1L]);
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[9L], u[6L], s[5L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[6L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[8L], u[6L], s[2L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[6L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[1L], u[6L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[0L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[1L], u[6L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[3L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[13L], u[3L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[0L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[13L], u[3L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[6L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[8L], u[6L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[2L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[8L], u[6L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[4L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[5L], u[7L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[14L], u[7L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[0L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[14L], u[7L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[5L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[4L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[4L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[5L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[6L], u[7L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[11L], u[7L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[0L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[11L], u[7L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[6L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[5L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[4L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[4L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[5L], u[6L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[0L], u[6L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[4L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[0L], u[6L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[5L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[4L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[4L], u[6L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[3L], u[6L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[0L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[3L], u[6L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[4L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[5L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[12L], u[5L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[0L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[12L], u[5L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[5L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[9L], u[7L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((z[0L], s[2L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[9L], u[7L], z[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[0L], s[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[0L], s[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[0L], s[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[0L], s[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[0L], s[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[0L], s[1L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[14L], u[2L], s[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[0L], s[2L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[11L], u[6L], s[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[6L], s[7L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[3L], u[0L], s[6L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[7L], u[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[7L], s[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[7L], s[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[7L], s[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[7L], s[1L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[13L], u[4L], s[7L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[7L], u[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[1L], s[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[1L], s[3L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[1L], u[4L], s[1L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[6L], s[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[6L], s[2L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[12L], u[3L], s[6L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[2L], s[5L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[0L], u[3L], s[2L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[6L], u[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[7L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[5L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[4L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[5L], u[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[6L], u[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[8L], t[14L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[11L], t[14L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[1L], t[13L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[9L], t[13L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[3L], t[12L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[0L], t[12L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[9L], t[11L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[0L], t[11L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[1L], t[8L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[3L], t[8L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[0L], t[7L], t[3L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[10L], t[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[10L], t[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[7L], t[8L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[9L], t[8L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[4L], t[8L], t[10L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[9L], t[8L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[7L], t[8L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[9L], t[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[4L], t[9L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[1L], t[8L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[4L], t[8L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[6L], t[8L], t[9L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[4L], t[8L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[1L], t[8L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[3L], t[7L], t[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[0L], t[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[6L], t[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[4L], t[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[0L], t[3L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[3L], t[1L], t[6L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[4L], t[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[5L], u[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[5L], t[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[7L], u[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[6L], u[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[4L], u[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], t[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[6L], t[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[2L], t[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[4L], t[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[5L], t[3L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((u[3L], u[4L], t[5L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[7L], u[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[3L], t[1L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((u[3L], u[0L], t[4L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[6L], u[3L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((u[6L], u[0L], t[3L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[7L], u[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[4L], u[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[5L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[3L], t[4L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((u[3L], u[2L], t[3L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[7L], u[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[6L], u[3L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((u[6L], u[2L], t[2L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[6L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((u[1L], u[0L], t[1L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[6L], u[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[7L], u[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[5L], u[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[4L], u[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[1L], t[2L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((u[6L], u[2L], t[1L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[6L], u[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[5L], u[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[4L], u[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[6L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((u[3L], u[7L], t[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[7L], u[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[2L], u[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[1L], u[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((t[0L], t[5L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((u[5L], u[4L], t[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[6L], u[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[6L], u[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[3L], u[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((u[0L], u[5L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.QUtilitiesLPAND = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit,Boolean)>>(typeof(QUtilities.LPAND));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> u, IQArray<Qubit> t, IQArray<Qubit> z, IQArray<Qubit> s, Boolean costing)
        {
            return __m__.Run<ForwardSBox, (IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((u, t, z, s, costing));
        }
    }

    public partial class SBox : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public SBox(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "SBox";
        String ICallable.FullName => "LPS19.SBox";
        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)> ForwardSBox
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (input,output,costing) = __in__;
#line hidden
            {
#line 361 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
                var (t,z,s) = (Allocate.Apply(15L), Allocate.Apply(1L), Allocate.Apply(8L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 363 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
                    var u = (IQArray<Qubit>)input?.Slice(new Range(7L, -(1L), 0L));
#line 365 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
                    ForwardSBox.Apply((u, t, z, s, costing));
#line 367 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
                    foreach (var i in new Range(0L, 7L))
#line hidden
                    {
#line 369 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
                        MicrosoftQuantumIntrinsicCNOT.Apply((s[i], output[(7L - i)]));
                    }

#line 372 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\LPS19.qs"
                    ForwardSBox.Adjoint.Apply((u, t, z, s, costing));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(t);
#line hidden
                    Release.Apply(z);
#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (input,output,costing) = __in__;
#line hidden
            {
#line hidden
                var (t,z,s) = (Allocate.Apply(15L), Allocate.Apply(1L), Allocate.Apply(8L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    var u = (IQArray<Qubit>)input?.Slice(new Range(7L, -(1L), 0L));
#line hidden
                    ForwardSBox.Adjoint.Adjoint.Apply((u, t, z, s, costing));
#line hidden
                    foreach (var i in RangeReverse.Apply(new Range(0L, 7L)))
#line hidden
                    {
#line hidden
                        MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((s[i], output[(7L - i)]));
                    }

#line hidden
                    ForwardSBox.Adjoint.Apply((u, t, z, s, costing));
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(t);
#line hidden
                    Release.Apply(z);
#line hidden
                    Release.Apply(s);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ForwardSBox = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(ForwardSBox));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> input, IQArray<Qubit> output, Boolean costing)
        {
            return __m__.Run<SBox, (IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((input, output, costing));
        }
    }
}