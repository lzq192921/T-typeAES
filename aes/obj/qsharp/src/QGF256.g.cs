#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QGF256\",\"Name\":\"Mul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"res\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":61}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" <summary>\",\" Set res = a * b.\",\" Assumes output register to be Zeroed.\",\" </summary>\",\" <param name=\\\"a\\\">Input register</param>\",\" <param name=\\\"b\\\">Input register</param>\",\" <param name=\\\"res\\\">Output register</param>\",\" <returns>Unit</returns>\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256\",\"Name\":\"Mul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":17,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256\",\"Name\":\"Mul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":62,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QGF256\",\"Name\":\"ForwardMul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":65,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"res\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":61},\"Item2\":{\"Line\":1,\"Column\":68}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256\",\"Name\":\"ForwardMul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":67,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256\",\"Name\":\"ForwardMul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":92,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QGF256\",\"Name\":\"UnrolledMul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":107,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"res\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" <summary>\",\" Set res = a * b.\",\" Assumes output register to be Zeroed.\",\" Unrolled version.\",\" </summary>\",\" <param name=\\\"a\\\">Input register</param>\",\" <param name=\\\"b\\\">Input register</param>\",\" <param name=\\\"res\\\">Output register</param>\",\" <returns>Unit</returns>\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256\",\"Name\":\"UnrolledMul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":109,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256\",\"Name\":\"UnrolledMul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":150,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QGF256\",\"Name\":\"Square\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":154,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":42},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256\",\"Name\":\"Square\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":156,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256\",\"Name\":\"Square\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":187,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QGF256\",\"Name\":\"Inverse24\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":197,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":52}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" <summary>\",\" Computes b = a^4.\",\" Assumes output register to be Zeroed.\",\" </summary>\",\" <param name=\\\"a\\\">Input register</param>\",\" <param name=\\\"b\\\">Output register</param>\",\" <returns>Unit</returns>\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256\",\"Name\":\"Inverse24\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":199,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256\",\"Name\":\"Inverse24\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":253,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QGF256\",\"Name\":\"Sixteenth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":275,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":52}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" <summary>\",\" Computes b = a^16.\",\" Assumes output register to be Zeroed.\",\" </summary>\",\" <param name=\\\"a\\\">Input register</param>\",\" <param name=\\\"b\\\">Output register</param>\",\" <returns>Unit</returns>\",\"\",\"\",\" <summary>\",\" Computes b = 1/a.\",\" Assumes output register and ancillas to be Zeroed.\",\" </summary>\",\" <param name=\\\"a\\\">Input register</param>\",\" <param name=\\\"b\\\">Output register</param>\",\" <param name=\\\"c\\\">Ancilla qubyte register</param>\",\" <param name=\\\"d\\\">Ancilla qubyte register</param>\",\" <param name=\\\"e\\\">Ancilla qubyte register</param>\",\" <returns>Unit</returns>\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256\",\"Name\":\"Sixteenth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":277,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256\",\"Name\":\"Sixteenth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":293,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QGF256.InPlace\",\"Name\":\"Square\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":306,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" <summary>\",\" Computes a^2 in place.\",\" </summary>\",\" <param name=\\\"a\\\">Input/Output register</param>\",\" <returns>Unit</returns>\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256.InPlace\",\"Name\":\"Square\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":308,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256.InPlace\",\"Name\":\"Square\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":319,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QGF256.InPlace\",\"Name\":\"Fourth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":327,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":37}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" <summary>\",\" Computes a^4 in place.\",\" </summary>\",\" <param name=\\\"a\\\">Input/Output register</param>\",\" <returns>Unit</returns>\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256.InPlace\",\"Name\":\"Fourth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":329,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256.InPlace\",\"Name\":\"Fourth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":362,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QGF256.InPlace\",\"Name\":\"SixtyFourth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":370,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" <summary>\",\" Computes a^64 in place.\",\" </summary>\",\" <param name=\\\"a\\\">Input/Output register</param>\",\" <returns>Unit</returns>\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256.InPlace\",\"Name\":\"SixtyFourth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":372,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QGF256.InPlace\",\"Name\":\"SixtyFourth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QGF256.qs\",\"Position\":{\"Item1\":422,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace QGF256
{
    public partial class Mul : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public Mul(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Mul";
        String ICallable.FullName => "QGF256.Mul";
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

        protected IAdjointable<(Qubit,Qubit,Qubit,Boolean)> QUtilitiesLPAND
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit)> QUtilitiesLPXOR
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (a,b,res,costing) = __in__;
#line hidden
            {
#line 20 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                var (t,m,p) = (Allocate.Apply(5L), Allocate.Apply(5L), Allocate.Apply(5L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 22 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((a[0L], a[1L], t[0L]));
#line 23 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((a[1L], a[3L], t[1L]));
#line 24 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((a[2L], a[0L], t[2L]));
#line 25 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((a[3L], a[2L], t[3L]));
#line 26 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((t[0L], t[3L], t[4L]));
#line 29 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((b[0L], b[1L], m[0L]));
#line 30 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((b[1L], b[3L], m[1L]));
#line 31 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((b[2L], b[0L], m[2L]));
#line 32 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((b[3L], b[2L], m[3L]));
#line 33 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((m[0L], m[3L], m[4L]));
#line 36 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[0L], b[0L], p[0L], costing));
#line 37 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[1L], b[1L], p[1L], costing));
#line 38 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[2L], b[2L], p[2L], costing));
#line 39 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[3L], b[3L], p[3L], costing));
#line 40 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((t[3L], m[3L], p[4L], costing));
#line 43 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((t[1L], m[1L], res[0L], costing));
#line 44 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((t[0L], m[0L], res[1L], costing));
#line 45 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((t[2L], m[2L], res[2L], costing));
#line 46 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((t[4L], m[4L], res[3L], costing));
#line 49 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((p[0L], res[0L]));
#line 50 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((p[4L], res[2L]));
#line 51 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((res[1L], res[3L]));
#line 52 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((res[0L], res[1L]));
#line 53 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((res[2L], res[3L]));
#line 54 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((p[1L], res[0L]));
#line 55 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((p[4L], res[1L]));
#line 56 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((p[0L], res[2L]));
#line 57 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((p[1L], res[2L]));
#line 58 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((p[2L], res[0L]));
#line 59 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((res[0L], res[3L]));
#line 60 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((p[3L], res[0L]));
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
                    Release.Apply(m);
#line hidden
                    Release.Apply(p);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,res,costing) = __in__;
#line hidden
            {
#line hidden
                var (t,m,p) = (Allocate.Apply(5L), Allocate.Apply(5L), Allocate.Apply(5L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((p[3L], res[0L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((res[0L], res[3L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((p[2L], res[0L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((p[1L], res[2L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((p[0L], res[2L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((p[4L], res[1L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((p[1L], res[0L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((res[2L], res[3L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((res[0L], res[1L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((res[1L], res[3L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((p[4L], res[2L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((p[0L], res[0L]));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((t[4L], m[4L], res[3L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((t[2L], m[2L], res[2L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((t[0L], m[0L], res[1L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((t[1L], m[1L], res[0L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((t[3L], m[3L], p[4L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[3L], b[3L], p[3L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[2L], b[2L], p[2L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[1L], b[1L], p[1L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[0L], b[0L], p[0L], costing));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((m[0L], m[3L], m[4L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((b[3L], b[2L], m[3L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((b[2L], b[0L], m[2L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((b[1L], b[3L], m[1L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((b[0L], b[1L], m[0L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((t[0L], t[3L], t[4L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((a[3L], a[2L], t[3L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((a[2L], a[0L], t[2L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((a[1L], a[3L], t[1L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((a[0L], a[1L], t[0L]));
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
                    Release.Apply(m);
#line hidden
                    Release.Apply(p);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QUtilitiesLPAND = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit,Boolean)>>(typeof(QUtilities.LPAND));
            this.QUtilitiesLPXOR = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(QUtilities.LPXOR));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, IQArray<Qubit> res, Boolean costing)
        {
            return __m__.Run<Mul, (IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((a, b, res, costing));
        }
    }

    public partial class ForwardMul : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public ForwardMul(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "ForwardMul";
        String ICallable.FullName => "QGF256.ForwardMul";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit,Boolean)> QUtilitiesLPAND
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit)> QUtilitiesLPXOR
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (a,b,res,costing) = __in__;
#line hidden
            {
#line 70 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                var (t,m,p) = (Allocate.Apply(5L), Allocate.Apply(5L), Allocate.Apply(5L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 72 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((a[0L], a[1L], t[0L]));
#line 73 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((a[1L], a[3L], t[1L]));
#line 74 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((a[2L], a[0L], t[2L]));
#line 75 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((a[3L], a[2L], t[3L]));
#line 76 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((t[0L], t[3L], t[4L]));
#line 79 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((b[0L], b[1L], m[0L]));
#line 80 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((b[1L], b[3L], m[1L]));
#line 81 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((b[2L], b[0L], m[2L]));
#line 82 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((b[3L], b[2L], m[3L]));
#line 83 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((m[0L], m[3L], m[4L]));
#line 86 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[0L], b[0L], p[0L], costing));
#line 87 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[1L], b[1L], p[1L], costing));
#line 88 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[2L], b[2L], p[2L], costing));
#line 89 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[3L], b[3L], p[3L], costing));
#line 90 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((t[3L], m[3L], p[4L], costing));
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
                    Release.Apply(m);
#line hidden
                    Release.Apply(p);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,res,costing) = __in__;
#line hidden
            {
#line hidden
                var (t,m,p) = (Allocate.Apply(5L), Allocate.Apply(5L), Allocate.Apply(5L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((t[3L], m[3L], p[4L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[3L], b[3L], p[3L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[2L], b[2L], p[2L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[1L], b[1L], p[1L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[0L], b[0L], p[0L], costing));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((m[0L], m[3L], m[4L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((b[3L], b[2L], m[3L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((b[2L], b[0L], m[2L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((b[1L], b[3L], m[1L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((b[0L], b[1L], m[0L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((t[0L], t[3L], t[4L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((a[3L], a[2L], t[3L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((a[2L], a[0L], t[2L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((a[1L], a[3L], t[1L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((a[0L], a[1L], t[0L]));
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
                    Release.Apply(m);
#line hidden
                    Release.Apply(p);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QUtilitiesLPAND = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit,Boolean)>>(typeof(QUtilities.LPAND));
            this.QUtilitiesLPXOR = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(QUtilities.LPXOR));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, IQArray<Qubit> res, Boolean costing)
        {
            return __m__.Run<ForwardMul, (IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((a, b, res, costing));
        }
    }

    public partial class UnrolledMul : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public UnrolledMul(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "UnrolledMul";
        String ICallable.FullName => "QGF256.UnrolledMul";
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

        protected IAdjointable<(Qubit,Qubit,Qubit,Boolean)> QUtilitiesLPAND
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit)> QUtilitiesLPXOR
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (a,b,res,costing) = __in__;
#line hidden
            {
#line 112 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                var (t,m,p) = (Allocate.Apply(5L), Allocate.Apply(5L), Allocate.Apply(5L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 114 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((a[0L], a[1L], t[0L]));
#line 115 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((a[1L], a[3L], t[1L]));
#line 116 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((a[2L], a[0L], t[2L]));
#line 117 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((a[3L], a[2L], t[3L]));
#line 118 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((t[0L], t[3L], t[4L]));
#line 121 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((b[0L], b[1L], m[0L]));
#line 122 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((b[1L], b[3L], m[1L]));
#line 123 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((b[2L], b[0L], m[2L]));
#line 124 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((b[3L], b[2L], m[3L]));
#line 125 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((m[0L], m[3L], m[4L]));
#line 128 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[3L], b[3L], res[0L], costing));
#line 129 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[0L], b[0L], res[1L], costing));
#line 130 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((t[3L], m[3L], res[2L], costing));
#line 131 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[2L], b[2L], res[3L], costing));
#line 134 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[1L], b[1L], p[0L], costing));
#line 135 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((t[0L], m[0L], p[1L], costing));
#line 136 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((t[1L], m[1L], p[2L], costing));
#line 137 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((t[2L], m[2L], p[3L], costing));
#line 138 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((t[4L], m[4L], p[4L], costing));
#line 140 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((res[2L], p[2L], p[1L]));
#line 141 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((res[1L], p[0L]));
#line 142 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((p[0L], p[3L]));
#line 143 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((p[3L], res[2L]));
#line 144 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((p[0L], res[3L], res[0L]));
#line 145 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((p[1L], res[1L]));
#line 146 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((p[3L], p[4L], res[3L]));
#line 147 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((p[2L], res[0L]));
#line 148 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((p[1L], res[3L]));
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
                    Release.Apply(m);
#line hidden
                    Release.Apply(p);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,res,costing) = __in__;
#line hidden
            {
#line hidden
                var (t,m,p) = (Allocate.Apply(5L), Allocate.Apply(5L), Allocate.Apply(5L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((p[1L], res[3L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((p[2L], res[0L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((p[3L], p[4L], res[3L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((p[1L], res[1L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((p[0L], res[3L], res[0L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((p[3L], res[2L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((p[0L], p[3L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((res[1L], p[0L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((res[2L], p[2L], p[1L]));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((t[4L], m[4L], p[4L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((t[2L], m[2L], p[3L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((t[1L], m[1L], p[2L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((t[0L], m[0L], p[1L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[1L], b[1L], p[0L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[2L], b[2L], res[3L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((t[3L], m[3L], res[2L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[0L], b[0L], res[1L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[3L], b[3L], res[0L], costing));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((m[0L], m[3L], m[4L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((b[3L], b[2L], m[3L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((b[2L], b[0L], m[2L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((b[1L], b[3L], m[1L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((b[0L], b[1L], m[0L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((t[0L], t[3L], t[4L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((a[3L], a[2L], t[3L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((a[2L], a[0L], t[2L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((a[1L], a[3L], t[1L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((a[0L], a[1L], t[0L]));
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
                    Release.Apply(m);
#line hidden
                    Release.Apply(p);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QUtilitiesLPAND = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit,Boolean)>>(typeof(QUtilities.LPAND));
            this.QUtilitiesLPXOR = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(QUtilities.LPXOR));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, IQArray<Qubit> res, Boolean costing)
        {
            return __m__.Run<UnrolledMul, (IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((a, b, res, costing));
        }
    }

    public partial class Square : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public Square(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Square";
        String ICallable.FullName => "QGF256.Square";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (a,b,costing) = __in__;
#line 159 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], b[0L]));
#line 160 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], b[2L]));
#line 161 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], b[3L]));
#line 162 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], b[4L]));
#line 163 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[4L], b[1L]));
#line 164 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[5L], b[6L]));
#line 165 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], b[5L]));
#line 166 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[7L], b[7L]));
#line 168 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], b[0L]));
#line 169 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], b[3L]));
#line 170 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], b[5L]));
#line 171 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], b[7L]));
#line 172 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[5L], b[4L]));
#line 173 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], b[6L]));
#line 176 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], b[7L]));
#line 177 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], b[3L]));
#line 178 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[5L], b[1L]));
#line 179 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], b[2L]));
#line 181 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], b[1L]));
#line 182 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], b[7L]));
#line 183 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], b[2L]));
#line 185 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], b[2L]));
#line 186 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], b[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,costing) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], b[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], b[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], b[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], b[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], b[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], b[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[5L], b[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], b[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], b[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], b[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[5L], b[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], b[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], b[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], b[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], b[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[7L], b[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], b[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[5L], b[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[4L], b[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], b[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], b[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], b[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], b[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, Boolean costing)
        {
            return __m__.Run<Square, (IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((a, b, costing));
        }
    }

    public partial class Inverse24 : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public Inverse24(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Inverse24";
        String ICallable.FullName => "QGF256.Inverse24";
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

        protected IAdjointable<(Qubit,Qubit,Qubit,Boolean)> QUtilitiesLPAND
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit)> QUtilitiesLPXNOR
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit)> QUtilitiesLPXOR
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Boolean)> QUtilitiesREWIRE
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (a,b,costing) = __in__;
#line hidden
            {
#line 202 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                var (q,m) = (Allocate.Apply(2L), Allocate.Apply(4L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 205 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((a[0L], a[3L], a[2L]));
#line 206 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], a[1L]));
#line 207 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((a[1L], a[2L], a[3L]));
#line 208 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], a[1L]));
#line 211 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesREWIRE.Apply((a[0L], a[1L], costing));
#line 212 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesREWIRE.Apply((a[0L], a[2L], costing));
#line 214 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], q[0L]));
#line 215 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], q[1L]));
#line 218 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[0L], a[2L], m[0L], costing));
#line 219 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((q[0L], a[3L], m[1L], costing));
#line 220 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((q[1L], a[1L], m[2L], costing));
#line 221 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((m[0L], m[3L]));
#line 222 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[0L]));
#line 223 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], a[2L]));
#line 224 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], q[1L]));
#line 227 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((m[3L], b[0L]));
#line 228 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], q[0L]));
#line 229 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((m[0L], b[2L]));
#line 230 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], m[0L]));
#line 231 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], m[3L]));
#line 234 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[0L], m[0L], b[3L], costing));
#line 235 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((q[0L], m[1L], b[2L], costing));
#line 236 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((a[2L], m[3L], b[1L], costing));
#line 237 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPAND.Apply((q[1L], m[2L], b[0L], costing));
#line 238 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], b[3L]));
#line 239 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], b[2L]));
#line 240 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], b[0L]));
#line 241 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], m[1L]));
#line 244 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((b[1L], b[0L]));
#line 245 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXOR.Apply((b[2L], b[0L], b[3L]));
#line 246 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesLPXNOR.Apply((b[1L], b[3L], b[2L]));
#line 247 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((b[3L], b[0L]));
#line 250 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesREWIRE.Apply((b[0L], b[1L], costing));
#line 251 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesREWIRE.Apply((b[1L], b[2L], costing));
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
                    Release.Apply(q);
#line hidden
                    Release.Apply(m);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,costing) = __in__;
#line hidden
            {
#line hidden
                var (q,m) = (Allocate.Apply(2L), Allocate.Apply(4L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    QUtilitiesREWIRE.Adjoint.Apply((b[1L], b[2L], costing));
#line hidden
                    QUtilitiesREWIRE.Adjoint.Apply((b[0L], b[1L], costing));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((b[3L], b[0L]));
#line hidden
                    QUtilitiesLPXNOR.Adjoint.Apply((b[1L], b[3L], b[2L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((b[2L], b[0L], b[3L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((b[1L], b[0L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], m[1L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], b[0L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], b[2L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], b[3L]));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((q[1L], m[2L], b[0L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[2L], m[3L], b[1L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((q[0L], m[1L], b[2L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[0L], m[0L], b[3L], costing));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], m[3L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], m[0L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((m[0L], b[2L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], q[0L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((m[3L], b[0L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], q[1L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], a[2L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[0L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((m[0L], m[3L]));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((q[1L], a[1L], m[2L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((q[0L], a[3L], m[1L], costing));
#line hidden
                    QUtilitiesLPAND.Adjoint.Apply((a[0L], a[2L], m[0L], costing));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], q[1L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], q[0L]));
#line hidden
                    QUtilitiesREWIRE.Adjoint.Apply((a[0L], a[2L], costing));
#line hidden
                    QUtilitiesREWIRE.Adjoint.Apply((a[0L], a[1L], costing));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], a[1L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((a[1L], a[2L], a[3L]));
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], a[1L]));
#line hidden
                    QUtilitiesLPXOR.Adjoint.Apply((a[0L], a[3L], a[2L]));
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
                    Release.Apply(q);
#line hidden
                    Release.Apply(m);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QUtilitiesLPAND = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit,Boolean)>>(typeof(QUtilities.LPAND));
            this.QUtilitiesLPXNOR = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(QUtilities.LPXNOR));
            this.QUtilitiesLPXOR = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(QUtilities.LPXOR));
            this.QUtilitiesREWIRE = this.Factory.Get<IAdjointable<(Qubit,Qubit,Boolean)>>(typeof(QUtilities.REWIRE));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, Boolean costing)
        {
            return __m__.Run<Inverse24, (IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((a, b, costing));
        }
    }

    public partial class Sixteenth : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public Sixteenth(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "Sixteenth";
        String ICallable.FullName => "QGF256.Sixteenth";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> Inverse24
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)> Mul
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)> UnrolledMul
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Boolean)> QGF256InPlaceSquare
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
            var (a,b,costing) = __in__;
#line hidden
            {
#line 280 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                var (e,f,g,h,m) = (Allocate.Apply(4L), Allocate.Apply(4L), Allocate.Apply(4L), Allocate.Apply(4L), Allocate.Apply(4L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 282 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(0L, 3L)), e, 4L));
#line 283 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(4L, 7L)), f, 4L));
#line 284 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(4L, 7L)), a?.Slice(new Range(0L, 3L)), 4L));
#line 285 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    UnrolledMul.Apply((a?.Slice(new Range(0L, 3L)), e, g, costing));
#line 286 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QGF256InPlaceSquare.Apply((f, costing));
#line 287 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesCNOTnBits.Apply((f, g, 4L));
#line 288 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    Inverse24.Apply((g, h, costing));
#line 289 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    QUtilitiesCNOTnBits.Apply((h, m, 4L));
#line 290 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    Mul.Apply((a?.Slice(new Range(0L, 3L)), h, b?.Slice(new Range(0L, 3L)), costing));
#line 291 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
                    Mul.Apply((a?.Slice(new Range(4L, 7L)), m, b?.Slice(new Range(4L, 7L)), costing));
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
                    Release.Apply(e);
#line hidden
                    Release.Apply(f);
#line hidden
                    Release.Apply(g);
#line hidden
                    Release.Apply(h);
#line hidden
                    Release.Apply(m);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,costing) = __in__;
#line hidden
            {
#line hidden
                var (e,f,g,h,m) = (Allocate.Apply(4L), Allocate.Apply(4L), Allocate.Apply(4L), Allocate.Apply(4L), Allocate.Apply(4L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    Mul.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), m, b?.Slice(new Range(4L, 7L)), costing));
#line hidden
                    Mul.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), h, b?.Slice(new Range(0L, 3L)), costing));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((h, m, 4L));
#line hidden
                    Inverse24.Adjoint.Apply((g, h, costing));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((f, g, 4L));
#line hidden
                    QGF256InPlaceSquare.Adjoint.Apply((f, costing));
#line hidden
                    UnrolledMul.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), e, g, costing));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), a?.Slice(new Range(0L, 3L)), 4L));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), f, 4L));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), e, 4L));
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
                    Release.Apply(e);
#line hidden
                    Release.Apply(f);
#line hidden
                    Release.Apply(g);
#line hidden
                    Release.Apply(h);
#line hidden
                    Release.Apply(m);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.Inverse24 = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(Inverse24));
            this.Mul = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(Mul));
            this.UnrolledMul = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(UnrolledMul));
            this.QGF256InPlaceSquare = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Boolean)>>(typeof(QGF256.InPlace.Square));
            this.QUtilitiesCNOTnBits = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)>>(typeof(QUtilities.CNOTnBits));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, Boolean costing)
        {
            return __m__.Run<Sixteenth, (IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((a, b, costing));
        }
    }
}

#line hidden
namespace QGF256.InPlace
{
    public partial class Square : Adjointable<(IQArray<Qubit>,Boolean)>, ICallable
    {
        public Square(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "Square";
        String ICallable.FullName => "QGF256.InPlace.Square";
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
            var (a,costing) = __in__;
#line 311 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[2L]));
#line 312 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], a[1L]));
#line 313 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[3L]));
#line 316 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            QUtilitiesREWIRE.Apply((a[0L], a[1L], costing));
#line 317 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            QUtilitiesREWIRE.Apply((a[0L], a[2L], costing));
#line 318 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            QUtilitiesREWIRE.Apply((a[2L], a[3L], costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,costing) = __in__;
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[2L], a[3L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[0L], a[2L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[0L], a[1L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], a[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[2L]));
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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, Boolean costing)
        {
            return __m__.Run<Square, (IQArray<Qubit>,Boolean), QVoid>((a, costing));
        }
    }

    public partial class Fourth : Adjointable<(IQArray<Qubit>,Boolean)>, ICallable
    {
        public Fourth(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "Fourth";
        String ICallable.FullName => "QGF256.InPlace.Fourth";
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
            var (a,costing) = __in__;
#line 332 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[5L], a[1L]));
#line 333 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], a[0L]));
#line 335 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[5L], a[3L]));
#line 336 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], a[1L]));
#line 338 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], a[2L]));
#line 340 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], a[1L]));
#line 341 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[5L], a[4L]));
#line 344 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], a[0L]));
#line 345 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], a[5L]));
#line 346 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], a[1L]));
#line 349 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], a[4L]));
#line 350 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[6L]));
#line 352 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], a[6L]));
#line 353 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[7L]));
#line 355 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], a[2L]));
#line 358 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            QUtilitiesREWIRE.Apply((a[1L], a[3L], costing));
#line 359 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            QUtilitiesREWIRE.Apply((a[2L], a[6L], costing));
#line 360 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            QUtilitiesREWIRE.Apply((a[1L], a[4L], costing));
#line 361 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            QUtilitiesREWIRE.Apply((a[5L], a[6L], costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,costing) = __in__;
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[5L], a[6L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[1L], a[4L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[2L], a[6L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[1L], a[3L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], a[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], a[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], a[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], a[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], a[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], a[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[5L], a[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], a[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], a[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], a[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[5L], a[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], a[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[5L], a[1L]));
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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, Boolean costing)
        {
            return __m__.Run<Fourth, (IQArray<Qubit>,Boolean), QVoid>((a, costing));
        }
    }

    public partial class SixtyFourth : Adjointable<(IQArray<Qubit>,Boolean)>, ICallable
    {
        public SixtyFourth(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "SixtyFourth";
        String ICallable.FullName => "QGF256.InPlace.SixtyFourth";
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
            var (a,costing) = __in__;
#line 375 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[4L], a[1L]));
#line 376 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[5L], a[0L]));
#line 377 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], a[2L]));
#line 379 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[4L], a[0L]));
#line 380 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], a[1L]));
#line 381 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[7L], a[2L]));
#line 384 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[4L], a[2L]));
#line 385 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], a[3L]));
#line 386 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[7L], a[1L]));
#line 388 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[0L]));
#line 389 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], a[4L]));
#line 391 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], a[0L]));
#line 392 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[7L], a[6L]));
#line 393 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], a[1L]));
#line 395 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], a[2L]));
#line 396 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[7L]));
#line 397 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], a[4L]));
#line 400 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], a[7L]));
#line 401 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[4L]));
#line 404 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], a[6L]));
#line 405 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[5L]));
#line 408 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], a[3L]));
#line 409 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[5L], a[7L]));
#line 412 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], a[1L]));
#line 413 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], a[3L]));
#line 414 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[4L], a[5L]));
#line 417 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            QUtilitiesREWIRE.Apply((a[1L], a[2L], costing));
#line 418 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            QUtilitiesREWIRE.Apply((a[2L], a[3L], costing));
#line 419 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            QUtilitiesREWIRE.Apply((a[2L], a[4L], costing));
#line 420 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            QUtilitiesREWIRE.Apply((a[4L], a[6L], costing));
#line 421 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QGF256.qs"
            QUtilitiesREWIRE.Apply((a[5L], a[7L], costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,costing) = __in__;
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[5L], a[7L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[4L], a[6L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[2L], a[4L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[2L], a[3L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[1L], a[2L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[4L], a[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], a[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], a[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[5L], a[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], a[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], a[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], a[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], a[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], a[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], a[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[7L], a[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], a[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], a[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[7L], a[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], a[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[4L], a[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[7L], a[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], a[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[4L], a[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], a[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[5L], a[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[4L], a[1L]));
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
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, Boolean costing)
        {
            return __m__.Run<SixtyFourth, (IQArray<Qubit>,Boolean), QVoid>((a, costing));
        }
    }
}