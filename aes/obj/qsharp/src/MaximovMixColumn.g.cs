#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MaximovMixColumn\",\"Name\":\"MixColumn\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/MaximovMixColumn.qs\",\"Position\":{\"Item1\":12,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"out_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"first_word\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":74}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"last_word\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":90}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":97},\"Item2\":{\"Line\":1,\"Column\":104}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MaximovMixColumn\",\"Name\":\"MixColumn\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/MaximovMixColumn.qs\",\"Position\":{\"Item1\":14,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MaximovMixColumn\",\"Name\":\"MixColumn\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/MaximovMixColumn.qs\",\"Position\":{\"Item1\":21,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MaximovMixColumn\",\"Name\":\"MixWord\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/MaximovMixColumn.qs\",\"Position\":{\"Item1\":26,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":33}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MaximovMixColumn\",\"Name\":\"MixWord\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/MaximovMixColumn.qs\",\"Position\":{\"Item1\":28,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MaximovMixColumn\",\"Name\":\"MixWord\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/MaximovMixColumn.qs\",\"Position\":{\"Item1\":67,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"MaximovMixColumn\",\"Name\":\"Mixbyte\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/MaximovMixColumn.qs\",\"Position\":{\"Item1\":72,\"Item2\":0},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":39}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MaximovMixColumn\",\"Name\":\"Mixbyte\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/MaximovMixColumn.qs\",\"Position\":{\"Item1\":74,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"MaximovMixColumn\",\"Name\":\"Mixbyte\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/MaximovMixColumn.qs\",\"Position\":{\"Item1\":87,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace MaximovMixColumn
{
    public partial class MixColumn : Adjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Int64,Int64,Boolean)>, ICallable
    {
        public MixColumn(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Int64,Int64,Boolean)>, IApplyData
        {
            public In((IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Int64,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "MixColumn";
        String ICallable.FullName => "MaximovMixColumn.MixColumn";
        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> MixWord
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        public override Func<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Int64,Int64,Boolean), QVoid> Body => (__in__) =>
        {
            var (in_state,out_state,first_word,last_word,costing) = __in__;
#line 17 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            foreach (var j in new Range(first_word, last_word))
#line hidden
            {
#line 19 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
                MixWord.Apply((in_state[j], out_state[j], costing));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Int64,Int64,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (in_state,out_state,first_word,last_word,costing) = __in__;
#line hidden
            foreach (var j in RangeReverse.Apply(new Range(first_word, last_word)))
#line hidden
            {
#line hidden
                MixWord.Adjoint.Apply((in_state[j], out_state[j], costing));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MixWord = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(MixWord));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
        }

        public override IApplyData __dataIn((IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Int64,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<IQArray<Qubit>> in_state, IQArray<IQArray<Qubit>> out_state, Int64 first_word, Int64 last_word, Boolean costing)
        {
            return __m__.Run<MixColumn, (IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Int64,Int64,Boolean), QVoid>((in_state, out_state, first_word, last_word, costing));
        }
    }

    public partial class MixWord : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public MixWord(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "MixWord";
        String ICallable.FullName => "MaximovMixColumn.MixWord";
        protected IAdjointable<(IQArray<Qubit>,Boolean)> Mixbyte
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)> QUtilitiesCNOTnBits
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (x,y,costing) = __in__;
#line 32 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(0L, 7L)), y?.Slice(new Range(8L, 15L)), 8L));
#line 33 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(8L, 15L)), y?.Slice(new Range(0L, 7L)), 8L));
#line 34 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(16L, 23L)), y?.Slice(new Range(24L, 31L)), 8L));
#line 35 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(24L, 31L)), y?.Slice(new Range(16L, 23L)), 8L));
#line 38 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(0L, 7L)), y?.Slice(new Range(16L, 23L)), 8L));
#line 39 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(8L, 15L)), y?.Slice(new Range(24L, 31L)), 8L));
#line 40 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(16L, 23L)), y?.Slice(new Range(0L, 7L)), 8L));
#line 41 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(24L, 31L)), y?.Slice(new Range(8L, 15L)), 8L));
#line 44 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(0L, 7L)), y?.Slice(new Range(24L, 31L)), 8L));
#line 45 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(8L, 15L)), y?.Slice(new Range(16L, 23L)), 8L));
#line 46 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(16L, 23L)), y?.Slice(new Range(8L, 15L)), 8L));
#line 47 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(24L, 31L)), y?.Slice(new Range(0L, 7L)), 8L));
#line 50 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            Mixbyte.Apply((x?.Slice(new Range(0L, 7L)), costing));
#line 51 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            Mixbyte.Apply((x?.Slice(new Range(8L, 15L)), costing));
#line 52 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            Mixbyte.Apply((x?.Slice(new Range(16L, 23L)), costing));
#line 53 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            Mixbyte.Apply((x?.Slice(new Range(24L, 31L)), costing));
#line 56 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(0L, 7L)), y?.Slice(new Range(0L, 7L)), 8L));
#line 57 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(8L, 15L)), y?.Slice(new Range(8L, 15L)), 8L));
#line 58 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(16L, 23L)), y?.Slice(new Range(16L, 23L)), 8L));
#line 59 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(24L, 31L)), y?.Slice(new Range(24L, 31L)), 8L));
#line 62 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(0L, 7L)), y?.Slice(new Range(24L, 31L)), 8L));
#line 63 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(8L, 15L)), y?.Slice(new Range(0L, 7L)), 8L));
#line 64 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(16L, 23L)), y?.Slice(new Range(8L, 15L)), 8L));
#line 65 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesCNOTnBits.Apply((x?.Slice(new Range(24L, 31L)), y?.Slice(new Range(16L, 23L)), 8L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,costing) = __in__;
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(24L, 31L)), y?.Slice(new Range(16L, 23L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(16L, 23L)), y?.Slice(new Range(8L, 15L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(8L, 15L)), y?.Slice(new Range(0L, 7L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(0L, 7L)), y?.Slice(new Range(24L, 31L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(24L, 31L)), y?.Slice(new Range(24L, 31L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(16L, 23L)), y?.Slice(new Range(16L, 23L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(8L, 15L)), y?.Slice(new Range(8L, 15L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(0L, 7L)), y?.Slice(new Range(0L, 7L)), 8L));
#line hidden
            Mixbyte.Adjoint.Apply((x?.Slice(new Range(24L, 31L)), costing));
#line hidden
            Mixbyte.Adjoint.Apply((x?.Slice(new Range(16L, 23L)), costing));
#line hidden
            Mixbyte.Adjoint.Apply((x?.Slice(new Range(8L, 15L)), costing));
#line hidden
            Mixbyte.Adjoint.Apply((x?.Slice(new Range(0L, 7L)), costing));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(24L, 31L)), y?.Slice(new Range(0L, 7L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(16L, 23L)), y?.Slice(new Range(8L, 15L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(8L, 15L)), y?.Slice(new Range(16L, 23L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(0L, 7L)), y?.Slice(new Range(24L, 31L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(24L, 31L)), y?.Slice(new Range(8L, 15L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(16L, 23L)), y?.Slice(new Range(0L, 7L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(8L, 15L)), y?.Slice(new Range(24L, 31L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(0L, 7L)), y?.Slice(new Range(16L, 23L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(24L, 31L)), y?.Slice(new Range(16L, 23L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(16L, 23L)), y?.Slice(new Range(24L, 31L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(8L, 15L)), y?.Slice(new Range(0L, 7L)), 8L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply((x?.Slice(new Range(0L, 7L)), y?.Slice(new Range(8L, 15L)), 8L));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Mixbyte = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Boolean)>>(typeof(Mixbyte));
            this.QUtilitiesCNOTnBits = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)>>(typeof(QUtilities.CNOTnBits));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, IQArray<Qubit> y, Boolean costing)
        {
            return __m__.Run<MixWord, (IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((x, y, costing));
        }
    }

    public partial class Mixbyte : Adjointable<(IQArray<Qubit>,Boolean)>, ICallable
    {
        public Mixbyte(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "Mixbyte";
        String ICallable.FullName => "MaximovMixColumn.Mixbyte";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Boolean)> QUtilitiesREWIRE
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (x,costing) = __in__;
#line 77 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesREWIRE.Apply((x[7L], x[6L], costing));
#line 78 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesREWIRE.Apply((x[6L], x[5L], costing));
#line 79 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesREWIRE.Apply((x[5L], x[4L], costing));
#line 80 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesREWIRE.Apply((x[4L], x[3L], costing));
#line 81 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesREWIRE.Apply((x[3L], x[2L], costing));
#line 82 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesREWIRE.Apply((x[2L], x[1L], costing));
#line 83 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            QUtilitiesREWIRE.Apply((x[1L], x[0L], costing));
#line 84 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((x[0L], x[1L]));
#line 85 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((x[0L], x[3L]));
#line 86 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\MaximovMixColumn.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((x[0L], x[4L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (x,costing) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((x[0L], x[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((x[0L], x[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((x[0L], x[1L]));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((x[1L], x[0L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((x[2L], x[1L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((x[3L], x[2L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((x[4L], x[3L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((x[5L], x[4L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((x[6L], x[5L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((x[7L], x[6L], costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.QUtilitiesREWIRE = this.Factory.Get<IAdjointable<(Qubit,Qubit,Boolean)>>(typeof(QUtilities.REWIRE));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, Boolean costing)
        {
            return __m__.Run<Mixbyte, (IQArray<Qubit>,Boolean), QVoid>((x, costing));
        }
    }
}