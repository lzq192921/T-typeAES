#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"ShiftRow\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":439,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"ShiftRow\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":441,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"ShiftRow\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":463,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"MixWord\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":466,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"word\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"MixWord\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":468,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"MixWord\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":587,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"MixColumn\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":590,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"MixColumn\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":592,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"MixColumn\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":599,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"RotByte\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":602,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"word\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"RotByte\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":604,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"RotByte\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":611,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"KeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":614,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"kexp_round\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":57}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"first_word\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":74}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"last_word\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":81},\"Item2\":{\"Line\":1,\"Column\":90}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":97},\"Item2\":{\"Line\":1,\"Column\":104}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"KeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":616,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.InPlace\",\"Name\":\"KeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":662,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"AddRoundKey\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":42,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"round_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"AddRoundKey\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":44,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"AddRoundKey\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":54,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"KeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":59,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":63}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"KeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":61,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"KeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":133,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"Round\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":137,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"out_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":63}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"round\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":74},\"Item2\":{\"Line\":1,\"Column\":79}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":86},\"Item2\":{\"Line\":1,\"Column\":93}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"Round\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":139,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"Round\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":146,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"FinalRound\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":149,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"out_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":68}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":79},\"Item2\":{\"Line\":1,\"Column\":81}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":88},\"Item2\":{\"Line\":1,\"Column\":95}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"FinalRound\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":151,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"FinalRound\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":157,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"ForwardRijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":164,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"expanded_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ciphertext\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":76}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":87},\"Item2\":{\"Line\":1,\"Column\":89}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":96},\"Item2\":{\"Line\":1,\"Column\":98}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":105},\"Item2\":{\"Line\":1,\"Column\":112}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"ForwardRijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":166,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"ForwardRijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":207,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"Rijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":210,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"expanded_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ciphertext\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":69}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":80},\"Item2\":{\"Line\":1,\"Column\":82}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":89},\"Item2\":{\"Line\":1,\"Column\":91}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":98},\"Item2\":{\"Line\":1,\"Column\":105}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"Rijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":212,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.Widest\",\"Name\":\"Rijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":227,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES\",\"Name\":\"ByteSub\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ancilla\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":70}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES\",\"Name\":\"ByteSub\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":9,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES\",\"Name\":\"ByteSub\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":21,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES\",\"Name\":\"SubByte\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":24,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input_word\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ancilla\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":65}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES\",\"Name\":\"SubByte\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":26,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES\",\"Name\":\"SubByte\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":34,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.SmartWide\",\"Name\":\"Round\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":238,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"out_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":63}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"round\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":74},\"Item2\":{\"Line\":1,\"Column\":79}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":86},\"Item2\":{\"Line\":1,\"Column\":88}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place_mixcolumn\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":95},\"Item2\":{\"Line\":1,\"Column\":113}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":121},\"Item2\":{\"Line\":1,\"Column\":128}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.SmartWide\",\"Name\":\"Round\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":240,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.SmartWide\",\"Name\":\"Round\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":309,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.SmartWide\",\"Name\":\"FinalRound\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":312,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"out_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":52}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":68}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"round\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":79},\"Item2\":{\"Line\":1,\"Column\":84}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":91},\"Item2\":{\"Line\":1,\"Column\":93}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":100},\"Item2\":{\"Line\":1,\"Column\":107}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.SmartWide\",\"Name\":\"FinalRound\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":314,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.SmartWide\",\"Name\":\"FinalRound\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":343,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.SmartWide\",\"Name\":\"ForwardRijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":346,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":59}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":68}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place_mixcolumn\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":75},\"Item2\":{\"Line\":1,\"Column\":93}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":101},\"Item2\":{\"Line\":1,\"Column\":108}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.SmartWide\",\"Name\":\"ForwardRijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":348,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.SmartWide\",\"Name\":\"ForwardRijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":413,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QAES.SmartWide\",\"Name\":\"Rijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":416,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"ciphertext\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":60}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":71},\"Item2\":{\"Line\":1,\"Column\":73}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":80},\"Item2\":{\"Line\":1,\"Column\":82}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place_mixcolumn\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":89},\"Item2\":{\"Line\":1,\"Column\":107}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":115},\"Item2\":{\"Line\":1,\"Column\":122}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.SmartWide\",\"Name\":\"Rijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":418,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QAES.SmartWide\",\"Name\":\"Rijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QAES.qs\",\"Position\":{\"Item1\":430,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace QAES.InPlace
{
    public partial class ShiftRow : Adjointable<(IQArray<IQArray<Qubit>>,Boolean)>, ICallable
    {
        public ShiftRow(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<IQArray<Qubit>>,Boolean)>, IApplyData
        {
            public In((IQArray<IQArray<Qubit>>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "ShiftRow";
        String ICallable.FullName => "QAES.InPlace.ShiftRow";
        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> QUtilitiesREWIREBytes
        {
            get;
            set;
        }

        public override Func<(IQArray<IQArray<Qubit>>,Boolean), QVoid> Body => (__in__) =>
        {
            var (state,costing) = __in__;
#line 451 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIREBytes.Apply((state[0L]?.Slice(new Range((8L * 1L), ((8L * 2L) - 1L))), state[1L]?.Slice(new Range((8L * 1L), ((8L * 2L) - 1L))), costing));
#line 452 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIREBytes.Apply((state[1L]?.Slice(new Range((8L * 1L), ((8L * 2L) - 1L))), state[2L]?.Slice(new Range((8L * 1L), ((8L * 2L) - 1L))), costing));
#line 453 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIREBytes.Apply((state[2L]?.Slice(new Range((8L * 1L), ((8L * 2L) - 1L))), state[3L]?.Slice(new Range((8L * 1L), ((8L * 2L) - 1L))), costing));
#line 456 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIREBytes.Apply((state[0L]?.Slice(new Range((8L * 2L), ((8L * 3L) - 1L))), state[2L]?.Slice(new Range((8L * 2L), ((8L * 3L) - 1L))), costing));
#line 457 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIREBytes.Apply((state[1L]?.Slice(new Range((8L * 2L), ((8L * 3L) - 1L))), state[3L]?.Slice(new Range((8L * 2L), ((8L * 3L) - 1L))), costing));
#line 460 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIREBytes.Apply((state[2L]?.Slice(new Range((8L * 3L), ((8L * 4L) - 1L))), state[3L]?.Slice(new Range((8L * 3L), ((8L * 4L) - 1L))), costing));
#line 461 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIREBytes.Apply((state[1L]?.Slice(new Range((8L * 3L), ((8L * 4L) - 1L))), state[2L]?.Slice(new Range((8L * 3L), ((8L * 4L) - 1L))), costing));
#line 462 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIREBytes.Apply((state[0L]?.Slice(new Range((8L * 3L), ((8L * 4L) - 1L))), state[1L]?.Slice(new Range((8L * 3L), ((8L * 4L) - 1L))), costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<IQArray<Qubit>>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (state,costing) = __in__;
#line hidden
            QUtilitiesREWIREBytes.Adjoint.Apply((state[0L]?.Slice(new Range((8L * 3L), ((8L * 4L) - 1L))), state[1L]?.Slice(new Range((8L * 3L), ((8L * 4L) - 1L))), costing));
#line hidden
            QUtilitiesREWIREBytes.Adjoint.Apply((state[1L]?.Slice(new Range((8L * 3L), ((8L * 4L) - 1L))), state[2L]?.Slice(new Range((8L * 3L), ((8L * 4L) - 1L))), costing));
#line hidden
            QUtilitiesREWIREBytes.Adjoint.Apply((state[2L]?.Slice(new Range((8L * 3L), ((8L * 4L) - 1L))), state[3L]?.Slice(new Range((8L * 3L), ((8L * 4L) - 1L))), costing));
#line hidden
            QUtilitiesREWIREBytes.Adjoint.Apply((state[1L]?.Slice(new Range((8L * 2L), ((8L * 3L) - 1L))), state[3L]?.Slice(new Range((8L * 2L), ((8L * 3L) - 1L))), costing));
#line hidden
            QUtilitiesREWIREBytes.Adjoint.Apply((state[0L]?.Slice(new Range((8L * 2L), ((8L * 3L) - 1L))), state[2L]?.Slice(new Range((8L * 2L), ((8L * 3L) - 1L))), costing));
#line hidden
            QUtilitiesREWIREBytes.Adjoint.Apply((state[2L]?.Slice(new Range((8L * 1L), ((8L * 2L) - 1L))), state[3L]?.Slice(new Range((8L * 1L), ((8L * 2L) - 1L))), costing));
#line hidden
            QUtilitiesREWIREBytes.Adjoint.Apply((state[1L]?.Slice(new Range((8L * 1L), ((8L * 2L) - 1L))), state[2L]?.Slice(new Range((8L * 1L), ((8L * 2L) - 1L))), costing));
#line hidden
            QUtilitiesREWIREBytes.Adjoint.Apply((state[0L]?.Slice(new Range((8L * 1L), ((8L * 2L) - 1L))), state[1L]?.Slice(new Range((8L * 1L), ((8L * 2L) - 1L))), costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QUtilitiesREWIREBytes = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(QUtilities.REWIREBytes));
        }

        public override IApplyData __dataIn((IQArray<IQArray<Qubit>>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<IQArray<Qubit>> state, Boolean costing)
        {
            return __m__.Run<ShiftRow, (IQArray<IQArray<Qubit>>,Boolean), QVoid>((state, costing));
        }
    }

    public partial class MixWord : Adjointable<(IQArray<Qubit>,Boolean)>, ICallable
    {
        public MixWord(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "MixWord";
        String ICallable.FullName => "QAES.InPlace.MixWord";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
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

        public override Func<(IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (word,costing) = __in__;
#line 472 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[31L], word[23L]));
#line 473 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[15L], word[31L]));
#line 474 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[4L], word[12L]));
#line 475 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[21L], word[13L]));
#line 476 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[9L], word[17L]));
#line 477 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[27L], word[11L]));
#line 478 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[28L], word[4L]));
#line 479 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[5L], word[21L]));
#line 480 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[24L], word[0L]));
#line 481 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[7L], word[15L]));
#line 482 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[1L], word[9L]));
#line 483 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[6L], word[14L]));
#line 484 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[16L], word[24L]));
#line 485 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[22L], word[6L]));
#line 486 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[31L], word[16L]));
#line 487 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[8L], word[24L]));
#line 488 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[26L], word[18L]));
#line 489 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[30L], word[22L]));
#line 490 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[10L], word[26L]));
#line 491 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[23L], word[8L]));
#line 492 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[13L], word[30L]));
#line 493 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[29L], word[13L]));
#line 494 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[13L], word[5L]));
#line 495 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[4L], word[29L]));
#line 496 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[11L], word[4L]));
#line 497 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[19L], word[11L]));
#line 498 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[12L], word[13L]));
#line 499 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[23L], word[19L]));
#line 500 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[31L], word[4L]));
#line 501 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[20L], word[12L]));
#line 502 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[12L], word[28L]));
#line 505 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesLPXOR.Apply((word[27L], word[19L], word[20L]));
#line 506 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesLPXOR.Apply((word[3L], word[31L], word[27L]));
#line 507 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[15L], word[12L]));
#line 508 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[11L], word[3L]));
#line 509 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesLPXOR.Apply((word[2L], word[10L], word[11L]));
#line 510 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[18L], word[19L]));
#line 511 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesLPXOR.Apply((word[18L], word[9L], word[10L]));
#line 512 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesLPXOR.Apply((word[2L], word[17L], word[18L]));
#line 513 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[9L], word[2L]));
#line 514 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[25L], word[17L]));
#line 515 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[17L], word[1L]));
#line 516 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[24L], word[25L]));
#line 517 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[8L], word[9L]));
#line 518 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[15L], word[24L]));
#line 519 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[15L], word[11L]));
#line 520 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[0L], word[8L]));
#line 521 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[23L], word[15L]));
#line 522 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[16L], word[17L]));
#line 523 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesLPXOR.Apply((word[0L], word[23L], word[16L]));
#line 524 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[31L], word[0L]));
#line 525 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[6L], word[23L]));
#line 526 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesLPXOR.Apply((word[7L], word[22L], word[31L]));
#line 527 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[6L], word[30L]));
#line 528 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[14L], word[7L]));
#line 531 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[21L], word[14L]));
#line 532 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[5L], word[6L]));
#line 533 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[21L], word[22L]));
#line 534 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[29L], word[5L]));
#line 535 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[28L], word[21L]));
#line 536 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[21L], word[29L]));
#line 537 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[13L], word[21L]));
#line 543 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[27L], word[12L]));
#line 544 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[26L], word[27L]));
#line 545 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[20L], word[28L]));
#line 546 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[4L], word[20L]));
#line 547 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[1L], word[26L]));
#line 548 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[30L], word[14L]));
#line 549 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[12L], word[4L]));
#line 550 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[19L], word[3L]));
#line 551 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[27L], word[19L]));
#line 552 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[25L], word[1L]));
#line 553 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[24L], word[0L]));
#line 554 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[0L], word[1L]));
#line 555 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[26L], word[2L]));
#line 556 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[9L], word[25L]));
#line 557 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[7L], word[15L]));
#line 558 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[23L], word[7L]));
#line 559 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[14L], word[6L]));
#line 560 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[17L], word[9L]));
#line 561 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[31L], word[23L]));
#line 562 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[18L], word[26L]));
#line 563 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[6L], word[22L]));
#line 564 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[0L], word[17L]));
#line 565 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((word[11L], word[27L]));
#line 570 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[0L], word[24L], costing));
#line 571 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[1L], word[25L], costing));
#line 572 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[1L], word[17L], costing));
#line 573 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[2L], word[10L], costing));
#line 574 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[10L], word[18L], costing));
#line 575 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[3L], word[11L], costing));
#line 576 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[11L], word[19L], costing));
#line 577 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[5L], word[13L], costing));
#line 578 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[13L], word[29L], costing));
#line 579 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[6L], word[14L], costing));
#line 580 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[14L], word[30L], costing));
#line 581 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[22L], word[30L], costing));
#line 582 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[7L], word[15L], costing));
#line 583 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[8L], word[16L], costing));
#line 584 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[12L], word[20L], costing));
#line 585 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[20L], word[28L], costing));
#line 586 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesREWIRE.Apply((word[23L], word[31L], costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (word,costing) = __in__;
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[23L], word[31L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[20L], word[28L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[12L], word[20L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[8L], word[16L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[7L], word[15L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[22L], word[30L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[14L], word[30L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[6L], word[14L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[13L], word[29L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[5L], word[13L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[11L], word[19L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[3L], word[11L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[10L], word[18L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[2L], word[10L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[1L], word[17L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[1L], word[25L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((word[0L], word[24L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[11L], word[27L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[0L], word[17L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[6L], word[22L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[18L], word[26L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[31L], word[23L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[17L], word[9L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[14L], word[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[23L], word[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[7L], word[15L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[9L], word[25L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[26L], word[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[0L], word[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[24L], word[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[25L], word[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[27L], word[19L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[19L], word[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[12L], word[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[30L], word[14L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[1L], word[26L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[4L], word[20L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[20L], word[28L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[26L], word[27L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[27L], word[12L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[13L], word[21L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[21L], word[29L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[28L], word[21L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[29L], word[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[21L], word[22L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[5L], word[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[21L], word[14L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[14L], word[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[6L], word[30L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((word[7L], word[22L], word[31L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[6L], word[23L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[31L], word[0L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((word[0L], word[23L], word[16L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[16L], word[17L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[23L], word[15L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[0L], word[8L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[15L], word[11L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[15L], word[24L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[8L], word[9L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[24L], word[25L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[17L], word[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[25L], word[17L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[9L], word[2L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((word[2L], word[17L], word[18L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((word[18L], word[9L], word[10L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[18L], word[19L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((word[2L], word[10L], word[11L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[11L], word[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[15L], word[12L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((word[3L], word[31L], word[27L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((word[27L], word[19L], word[20L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[12L], word[28L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[20L], word[12L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[31L], word[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[23L], word[19L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[12L], word[13L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[19L], word[11L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[11L], word[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[4L], word[29L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[13L], word[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[29L], word[13L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[13L], word[30L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[23L], word[8L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[10L], word[26L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[30L], word[22L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[26L], word[18L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[8L], word[24L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[31L], word[16L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[22L], word[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[16L], word[24L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[6L], word[14L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[1L], word[9L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[7L], word[15L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[24L], word[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[5L], word[21L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[28L], word[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[27L], word[11L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[9L], word[17L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[21L], word[13L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[4L], word[12L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[15L], word[31L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((word[31L], word[23L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.QUtilitiesLPXOR = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(QUtilities.LPXOR));
            this.QUtilitiesREWIRE = this.Factory.Get<IAdjointable<(Qubit,Qubit,Boolean)>>(typeof(QUtilities.REWIRE));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> word, Boolean costing)
        {
            return __m__.Run<MixWord, (IQArray<Qubit>,Boolean), QVoid>((word, costing));
        }
    }

    public partial class MixColumn : Adjointable<(IQArray<IQArray<Qubit>>,Boolean)>, ICallable
    {
        public MixColumn(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<IQArray<Qubit>>,Boolean)>, IApplyData
        {
            public In((IQArray<IQArray<Qubit>>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "MixColumn";
        String ICallable.FullName => "QAES.InPlace.MixColumn";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Boolean)> MixWord
        {
            get;
            set;
        }

        public override Func<(IQArray<IQArray<Qubit>>,Boolean), QVoid> Body => (__in__) =>
        {
            var (state,costing) = __in__;
#line 595 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            foreach (var j in new Range(0L, 3L))
#line hidden
            {
#line 597 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                MixWord.Apply((state[j], costing));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<IQArray<Qubit>>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (state,costing) = __in__;
#line hidden
            foreach (var j in RangeReverse.Apply(new Range(0L, 3L)))
#line hidden
            {
#line hidden
                MixWord.Adjoint.Apply((state[j], costing));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MixWord = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Boolean)>>(typeof(MixWord));
        }

        public override IApplyData __dataIn((IQArray<IQArray<Qubit>>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<IQArray<Qubit>> state, Boolean costing)
        {
            return __m__.Run<MixColumn, (IQArray<IQArray<Qubit>>,Boolean), QVoid>((state, costing));
        }
    }

    public partial class RotByte : Adjointable<(IQArray<Qubit>,Boolean)>, ICallable
    {
        public RotByte(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "RotByte";
        String ICallable.FullName => "QAES.InPlace.RotByte";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> QUtilitiesREWIREBytes
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (word,costing) = __in__;
#line 607 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            foreach (var i in new Range(0L, 2L))
#line hidden
            {
#line 609 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QUtilitiesREWIREBytes.Apply((word?.Slice(new Range((i * 8L), (((i + 1L) * 8L) - 1L))), word?.Slice(new Range(((i + 1L) * 8L), (((i + 2L) * 8L) - 1L))), costing));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (word,costing) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, 2L)))
#line hidden
            {
#line hidden
                QUtilitiesREWIREBytes.Adjoint.Apply((word?.Slice(new Range((i * 8L), (((i + 1L) * 8L) - 1L))), word?.Slice(new Range(((i + 1L) * 8L), (((i + 2L) * 8L) - 1L))), costing));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.QUtilitiesREWIREBytes = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(QUtilities.REWIREBytes));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> word, Boolean costing)
        {
            return __m__.Run<RotByte, (IQArray<Qubit>,Boolean), QVoid>((word, costing));
        }
    }

    public partial class KeyExpansion : Adjointable<(IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean)>, ICallable
    {
        public KeyExpansion(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "KeyExpansion";
        String ICallable.FullName => "QAES.InPlace.KeyExpansion";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> QAESSubByte
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Boolean)> RotByte
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)> QUtilitiesCNOTnBits
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean), QVoid> Body => (__in__) =>
        {
            var (key,kexp_round,Nk,first_word,last_word,costing) = __in__;
#line 619 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            foreach (var i in new Range(first_word, last_word))
#line hidden
            {
#line 621 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                if ((i == 0L))
                {
#line 623 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    RotByte.Apply((key?.Slice(new Range((32L * (Nk - 1L)), ((32L * Nk) - 1L))), costing));
#line 624 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QAESSubByte.Apply((key?.Slice(new Range((32L * (Nk - 1L)), ((32L * Nk) - 1L))), key?.Slice(new Range((32L * 0L), ((32L * 1L) - 1L))), costing));
#line 625 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    RotByte.Adjoint.Apply((key?.Slice(new Range((32L * (Nk - 1L)), ((32L * Nk) - 1L))), costing));
#line 628 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    if (((kexp_round > 0L) && (kexp_round < 9L)))
                    {
#line 631 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        MicrosoftQuantumIntrinsicX.Apply(key[(kexp_round - 1L)]);
                    }
                    else if ((kexp_round == 9L))
                    {
#line 636 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        MicrosoftQuantumIntrinsicX.Apply(key[0L]);
#line 637 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        MicrosoftQuantumIntrinsicX.Apply(key[1L]);
#line 638 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        MicrosoftQuantumIntrinsicX.Apply(key[3L]);
#line 639 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        MicrosoftQuantumIntrinsicX.Apply(key[4L]);
                    }
                    else if ((kexp_round == 10L))
                    {
#line 644 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        MicrosoftQuantumIntrinsicX.Apply(key[1L]);
#line 645 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        MicrosoftQuantumIntrinsicX.Apply(key[2L]);
#line 646 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        MicrosoftQuantumIntrinsicX.Apply(key[4L]);
#line 647 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        MicrosoftQuantumIntrinsicX.Apply(key[5L]);
                    }
                }
                else
                {
#line 652 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    if (((Nk == 8L) && (i == 4L)))
                    {
#line 654 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        QAESSubByte.Apply((key?.Slice(new Range((32L * (i - 1L)), ((32L * i) - 1L))), key?.Slice(new Range((32L * i), ((32L * (i + 1L)) - 1L))), costing));
                    }
                    else
                    {
#line 658 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        QUtilitiesCNOTnBits.Apply((key?.Slice(new Range((32L * (i - 1L)), ((32L * i) - 1L))), key?.Slice(new Range((32L * i), ((32L * (i + 1L)) - 1L))), 32L));
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (key,kexp_round,Nk,first_word,last_word,costing) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(first_word, last_word)))
#line hidden
            {
#line hidden
                if ((i == 0L))
                {
#line hidden
                    if (((kexp_round > 0L) && (kexp_round < 9L)))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[(kexp_round - 1L)]);
                    }
                    else if ((kexp_round == 9L))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[4L]);
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[3L]);
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[1L]);
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[0L]);
                    }
                    else if ((kexp_round == 10L))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[5L]);
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[4L]);
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[2L]);
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[1L]);
                    }

#line hidden
                    RotByte.Adjoint.Adjoint.Apply((key?.Slice(new Range((32L * (Nk - 1L)), ((32L * Nk) - 1L))), costing));
#line hidden
                    QAESSubByte.Adjoint.Apply((key?.Slice(new Range((32L * (Nk - 1L)), ((32L * Nk) - 1L))), key?.Slice(new Range((32L * 0L), ((32L * 1L) - 1L))), costing));
#line hidden
                    RotByte.Adjoint.Apply((key?.Slice(new Range((32L * (Nk - 1L)), ((32L * Nk) - 1L))), costing));
                }
                else
                {
#line hidden
                    if (((Nk == 8L) && (i == 4L)))
                    {
#line hidden
                        QAESSubByte.Adjoint.Apply((key?.Slice(new Range((32L * (i - 1L)), ((32L * i) - 1L))), key?.Slice(new Range((32L * i), ((32L * (i + 1L)) - 1L))), costing));
                    }
                    else
                    {
#line hidden
                        QUtilitiesCNOTnBits.Adjoint.Apply((key?.Slice(new Range((32L * (i - 1L)), ((32L * i) - 1L))), key?.Slice(new Range((32L * i), ((32L * (i + 1L)) - 1L))), 32L));
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.QAESSubByte = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(QAES.SubByte));
            this.RotByte = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Boolean)>>(typeof(RotByte));
            this.QUtilitiesCNOTnBits = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)>>(typeof(QUtilities.CNOTnBits));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> key, Int64 kexp_round, Int64 Nk, Int64 first_word, Int64 last_word, Boolean costing)
        {
            return __m__.Run<KeyExpansion, (IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean), QVoid>((key, kexp_round, Nk, first_word, last_word, costing));
        }
    }
}

#line hidden
namespace QAES.Widest
{
    public partial class AddRoundKey : Adjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)>, ICallable
    {
        public AddRoundKey(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<IQArray<Qubit>>,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "AddRoundKey";
        String ICallable.FullName => "QAES.Widest.AddRoundKey";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<IQArray<Qubit>>,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (state,round_key) = __in__;
#line 47 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            foreach (var j in new Range(0L, 3L))
#line hidden
            {
#line 49 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                foreach (var i in new Range(0L, 31L))
#line hidden
                {
#line 51 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    MicrosoftQuantumIntrinsicCNOT.Apply((round_key[((j * 32L) + i)], state[j][i]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<IQArray<Qubit>>,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (state,round_key) = __in__;
#line hidden
            foreach (var j in RangeReverse.Apply(new Range(0L, 3L)))
#line hidden
            {
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, 31L)))
#line hidden
                {
#line hidden
                    MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((round_key[((j * 32L) + i)], state[j][i]));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((IQArray<IQArray<Qubit>>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<IQArray<Qubit>> state, IQArray<Qubit> round_key)
        {
            return __m__.Run<AddRoundKey, (IQArray<IQArray<Qubit>>,IQArray<Qubit>), QVoid>((state, round_key));
        }
    }

    public partial class KeyExpansion : Adjointable<(IQArray<Qubit>,Int64,Int64,Boolean)>, ICallable
    {
        public KeyExpansion(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Int64,Int64,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,Int64,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "KeyExpansion";
        String ICallable.FullName => "QAES.Widest.KeyExpansion";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> QAESSubByte
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Boolean)> QAESInPlaceRotByte
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>)> QUtilitiesCNOTBytes
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Int64,Int64,Boolean), QVoid> Body => (__in__) =>
        {
            var (key,Nr,Nk,costing) = __in__;
#line 73 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            foreach (var i in new Range(Nk, ((4L * (Nr + 1L)) - 1L)))
#line hidden
            {
#line 79 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                if ((((i % Nk) != 0L) && (((i % Nk) != 4L) || (Nk <= 6L))))
                {
#line 82 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QUtilitiesCNOTBytes.Apply((key?.Slice(new Range((((i - 1L) * 32L) + 0L), (((i - 1L) * 32L) + 7L))), key?.Slice(new Range(((i * 32L) + 0L), ((i * 32L) + 7L)))));
#line 83 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QUtilitiesCNOTBytes.Apply((key?.Slice(new Range((((i - 1L) * 32L) + 8L), (((i - 1L) * 32L) + 15L))), key?.Slice(new Range(((i * 32L) + 8L), ((i * 32L) + 15L)))));
#line 84 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QUtilitiesCNOTBytes.Apply((key?.Slice(new Range((((i - 1L) * 32L) + 16L), (((i - 1L) * 32L) + 23L))), key?.Slice(new Range(((i * 32L) + 16L), ((i * 32L) + 23L)))));
#line 85 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QUtilitiesCNOTBytes.Apply((key?.Slice(new Range((((i - 1L) * 32L) + 24L), (((i - 1L) * 32L) + 31L))), key?.Slice(new Range(((i * 32L) + 24L), ((i * 32L) + 31L)))));
                }
                else
                {
#line 89 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    if (((i % Nk) == 0L))
                    {
#line 93 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        QAESInPlaceRotByte.Apply((key?.Slice(new Range((((i - 1L) * 32L) + 0L), (((i - 1L) * 32L) + 31L))), costing));
#line 94 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        QAESSubByte.Apply((key?.Slice(new Range((((i - 1L) * 32L) + 0L), (((i - 1L) * 32L) + 31L))), key?.Slice(new Range((i * 32L), (((i + 1L) * 32L) - 1L))), costing));
#line 95 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        QAESInPlaceRotByte.Adjoint.Apply((key?.Slice(new Range((((i - 1L) * 32L) + 0L), (((i - 1L) * 32L) + 31L))), costing));
#line 98 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        if ((((i / Nk) > 0L) && ((i / Nk) < 9L)))
                        {
#line 101 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                            MicrosoftQuantumIntrinsicX.Apply(key[(((i * 32L) + (i / Nk)) - 1L)]);
                        }
                        else if (((i / Nk) == 9L))
                        {
#line 106 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                            MicrosoftQuantumIntrinsicX.Apply(key[((i * 32L) + 0L)]);
#line 107 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                            MicrosoftQuantumIntrinsicX.Apply(key[((i * 32L) + 1L)]);
#line 108 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                            MicrosoftQuantumIntrinsicX.Apply(key[((i * 32L) + 3L)]);
#line 109 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                            MicrosoftQuantumIntrinsicX.Apply(key[((i * 32L) + 4L)]);
                        }
                        else if (((i / Nk) == 10L))
                        {
#line 114 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                            MicrosoftQuantumIntrinsicX.Apply(key[((i * 32L) + 1L)]);
#line 115 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                            MicrosoftQuantumIntrinsicX.Apply(key[((i * 32L) + 2L)]);
#line 116 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                            MicrosoftQuantumIntrinsicX.Apply(key[((i * 32L) + 4L)]);
#line 117 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                            MicrosoftQuantumIntrinsicX.Apply(key[((i * 32L) + 5L)]);
                        }
                    }
                    else if (((Nk > 6L) && ((i % Nk) == 4L)))
                    {
#line 123 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        QAESSubByte.Apply((key?.Slice(new Range(((i - 1L) * 32L), ((i * 32L) - 1L))), key?.Slice(new Range((i * 32L), (((i + 1L) * 32L) - 1L))), costing));
                    }
                }

#line 128 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QUtilitiesCNOTBytes.Apply((key?.Slice(new Range((((i - Nk) * 32L) + 0L), (((i - Nk) * 32L) + 7L))), key?.Slice(new Range(((i * 32L) + 0L), ((i * 32L) + 7L)))));
#line 129 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QUtilitiesCNOTBytes.Apply((key?.Slice(new Range((((i - Nk) * 32L) + 8L), (((i - Nk) * 32L) + 15L))), key?.Slice(new Range(((i * 32L) + 8L), ((i * 32L) + 15L)))));
#line 130 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QUtilitiesCNOTBytes.Apply((key?.Slice(new Range((((i - Nk) * 32L) + 16L), (((i - Nk) * 32L) + 23L))), key?.Slice(new Range(((i * 32L) + 16L), ((i * 32L) + 23L)))));
#line 131 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QUtilitiesCNOTBytes.Apply((key?.Slice(new Range((((i - Nk) * 32L) + 24L), (((i - Nk) * 32L) + 31L))), key?.Slice(new Range(((i * 32L) + 24L), ((i * 32L) + 31L)))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Int64,Int64,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (key,Nr,Nk,costing) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(Nk, ((4L * (Nr + 1L)) - 1L))))
#line hidden
            {
#line hidden
                QUtilitiesCNOTBytes.Adjoint.Apply((key?.Slice(new Range((((i - Nk) * 32L) + 24L), (((i - Nk) * 32L) + 31L))), key?.Slice(new Range(((i * 32L) + 24L), ((i * 32L) + 31L)))));
#line hidden
                QUtilitiesCNOTBytes.Adjoint.Apply((key?.Slice(new Range((((i - Nk) * 32L) + 16L), (((i - Nk) * 32L) + 23L))), key?.Slice(new Range(((i * 32L) + 16L), ((i * 32L) + 23L)))));
#line hidden
                QUtilitiesCNOTBytes.Adjoint.Apply((key?.Slice(new Range((((i - Nk) * 32L) + 8L), (((i - Nk) * 32L) + 15L))), key?.Slice(new Range(((i * 32L) + 8L), ((i * 32L) + 15L)))));
#line hidden
                QUtilitiesCNOTBytes.Adjoint.Apply((key?.Slice(new Range((((i - Nk) * 32L) + 0L), (((i - Nk) * 32L) + 7L))), key?.Slice(new Range(((i * 32L) + 0L), ((i * 32L) + 7L)))));
#line hidden
                if ((((i % Nk) != 0L) && (((i % Nk) != 4L) || (Nk <= 6L))))
                {
#line hidden
                    QUtilitiesCNOTBytes.Adjoint.Apply((key?.Slice(new Range((((i - 1L) * 32L) + 24L), (((i - 1L) * 32L) + 31L))), key?.Slice(new Range(((i * 32L) + 24L), ((i * 32L) + 31L)))));
#line hidden
                    QUtilitiesCNOTBytes.Adjoint.Apply((key?.Slice(new Range((((i - 1L) * 32L) + 16L), (((i - 1L) * 32L) + 23L))), key?.Slice(new Range(((i * 32L) + 16L), ((i * 32L) + 23L)))));
#line hidden
                    QUtilitiesCNOTBytes.Adjoint.Apply((key?.Slice(new Range((((i - 1L) * 32L) + 8L), (((i - 1L) * 32L) + 15L))), key?.Slice(new Range(((i * 32L) + 8L), ((i * 32L) + 15L)))));
#line hidden
                    QUtilitiesCNOTBytes.Adjoint.Apply((key?.Slice(new Range((((i - 1L) * 32L) + 0L), (((i - 1L) * 32L) + 7L))), key?.Slice(new Range(((i * 32L) + 0L), ((i * 32L) + 7L)))));
                }
                else
                {
#line hidden
                    if (((i % Nk) == 0L))
                    {
#line hidden
                        if ((((i / Nk) > 0L) && ((i / Nk) < 9L)))
                        {
#line hidden
                            MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[(((i * 32L) + (i / Nk)) - 1L)]);
                        }
                        else if (((i / Nk) == 9L))
                        {
#line hidden
                            MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[((i * 32L) + 4L)]);
#line hidden
                            MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[((i * 32L) + 3L)]);
#line hidden
                            MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[((i * 32L) + 1L)]);
#line hidden
                            MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[((i * 32L) + 0L)]);
                        }
                        else if (((i / Nk) == 10L))
                        {
#line hidden
                            MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[((i * 32L) + 5L)]);
#line hidden
                            MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[((i * 32L) + 4L)]);
#line hidden
                            MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[((i * 32L) + 2L)]);
#line hidden
                            MicrosoftQuantumIntrinsicX.Adjoint.Apply(key[((i * 32L) + 1L)]);
                        }

#line hidden
                        QAESInPlaceRotByte.Adjoint.Adjoint.Apply((key?.Slice(new Range((((i - 1L) * 32L) + 0L), (((i - 1L) * 32L) + 31L))), costing));
#line hidden
                        QAESSubByte.Adjoint.Apply((key?.Slice(new Range((((i - 1L) * 32L) + 0L), (((i - 1L) * 32L) + 31L))), key?.Slice(new Range((i * 32L), (((i + 1L) * 32L) - 1L))), costing));
#line hidden
                        QAESInPlaceRotByte.Adjoint.Apply((key?.Slice(new Range((((i - 1L) * 32L) + 0L), (((i - 1L) * 32L) + 31L))), costing));
                    }
                    else if (((Nk > 6L) && ((i % Nk) == 4L)))
                    {
#line hidden
                        QAESSubByte.Adjoint.Apply((key?.Slice(new Range(((i - 1L) * 32L), ((i * 32L) - 1L))), key?.Slice(new Range((i * 32L), (((i + 1L) * 32L) - 1L))), costing));
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.QAESSubByte = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(QAES.SubByte));
            this.QAESInPlaceRotByte = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Boolean)>>(typeof(QAES.InPlace.RotByte));
            this.QUtilitiesCNOTBytes = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>)>>(typeof(QUtilities.CNOTBytes));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Int64,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> key, Int64 Nr, Int64 Nk, Boolean costing)
        {
            return __m__.Run<KeyExpansion, (IQArray<Qubit>,Int64,Int64,Boolean), QVoid>((key, Nr, Nk, costing));
        }
    }

    public partial class Round : Adjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean)>, ICallable
    {
        public Round(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean)>, IApplyData
        {
            public In((IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Round";
        String ICallable.FullName => "QAES.Widest.Round";
        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean)> QAESByteSub
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)> QAESInPlaceMixColumn
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)> QAESInPlaceShiftRow
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)> AddRoundKey
        {
            get;
            set;
        }

        public override Func<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean), QVoid> Body => (__in__) =>
        {
            var (in_state,out_state,key,round,costing) = __in__;
#line 142 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QAESByteSub.Apply((in_state, out_state, costing));
#line 143 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QAESInPlaceShiftRow.Apply((out_state, costing));
#line 144 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QAESInPlaceMixColumn.Apply((out_state, costing));
#line 145 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            AddRoundKey.Apply((out_state, key?.Slice(new Range(((4L * round) * 32L), (((4L * (round + 1L)) * 32L) - 1L)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (in_state,out_state,key,round,costing) = __in__;
#line hidden
            AddRoundKey.Adjoint.Apply((out_state, key?.Slice(new Range(((4L * round) * 32L), (((4L * (round + 1L)) * 32L) - 1L)))));
#line hidden
            QAESInPlaceMixColumn.Adjoint.Apply((out_state, costing));
#line hidden
            QAESInPlaceShiftRow.Adjoint.Apply((out_state, costing));
#line hidden
            QAESByteSub.Adjoint.Apply((in_state, out_state, costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QAESByteSub = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean)>>(typeof(QAES.ByteSub));
            this.QAESInPlaceMixColumn = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)>>(typeof(QAES.InPlace.MixColumn));
            this.QAESInPlaceShiftRow = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)>>(typeof(QAES.InPlace.ShiftRow));
            this.AddRoundKey = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)>>(typeof(AddRoundKey));
        }

        public override IApplyData __dataIn((IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<IQArray<Qubit>> in_state, IQArray<IQArray<Qubit>> out_state, IQArray<Qubit> key, Int64 round, Boolean costing)
        {
            return __m__.Run<Round, (IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean), QVoid>((in_state, out_state, key, round, costing));
        }
    }

    public partial class FinalRound : Adjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean)>, ICallable
    {
        public FinalRound(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean)>, IApplyData
        {
            public In((IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "FinalRound";
        String ICallable.FullName => "QAES.Widest.FinalRound";
        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean)> QAESByteSub
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)> QAESInPlaceShiftRow
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)> AddRoundKey
        {
            get;
            set;
        }

        public override Func<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean), QVoid> Body => (__in__) =>
        {
            var (in_state,out_state,key,Nr,costing) = __in__;
#line 154 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QAESByteSub.Apply((in_state, out_state, costing));
#line 155 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QAESInPlaceShiftRow.Apply((out_state, costing));
#line 156 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            AddRoundKey.Apply((out_state, key?.Slice(new Range(((4L * Nr) * 32L), (((4L * (Nr + 1L)) * 32L) - 1L)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (in_state,out_state,key,Nr,costing) = __in__;
#line hidden
            AddRoundKey.Adjoint.Apply((out_state, key?.Slice(new Range(((4L * Nr) * 32L), (((4L * (Nr + 1L)) * 32L) - 1L)))));
#line hidden
            QAESInPlaceShiftRow.Adjoint.Apply((out_state, costing));
#line hidden
            QAESByteSub.Adjoint.Apply((in_state, out_state, costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QAESByteSub = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean)>>(typeof(QAES.ByteSub));
            this.QAESInPlaceShiftRow = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)>>(typeof(QAES.InPlace.ShiftRow));
            this.AddRoundKey = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)>>(typeof(AddRoundKey));
        }

        public override IApplyData __dataIn((IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<IQArray<Qubit>> in_state, IQArray<IQArray<Qubit>> out_state, IQArray<Qubit> key, Int64 Nr, Boolean costing)
        {
            return __m__.Run<FinalRound, (IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean), QVoid>((in_state, out_state, key, Nr, costing));
        }
    }

    public partial class ForwardRijndael : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean)>, ICallable
    {
        public ForwardRijndael(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "ForwardRijndael";
        String ICallable.FullName => "QAES.Widest.ForwardRijndael";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)> AddRoundKey
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean)> FinalRound
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Int64,Int64,Boolean)> KeyExpansion
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean)> Round
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean), QVoid> Body => (__in__) =>
        {
            var (expanded_key,state,ciphertext,Nr,Nk,costing) = __in__;
#line 169 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            KeyExpansion.Apply((expanded_key, Nr, Nk, costing));
#line 172 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            AddRoundKey.Apply((new QArray<IQArray<Qubit>>(state?.Slice(new Range((0L * 32L), ((1L * 32L) - 1L))), state?.Slice(new Range((1L * 32L), ((2L * 32L) - 1L))), state?.Slice(new Range((2L * 32L), ((3L * 32L) - 1L))), state?.Slice(new Range((3L * 32L), ((4L * 32L) - 1L)))), expanded_key?.Slice(new Range(0L, (4L * 32L)))));
#line 179 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            foreach (var i in new Range(1L, (Nr - 1L)))
#line hidden
            {
#line 182 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                Round.Apply((new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (0L * 32L)), ((((4L * 32L) * (i - 1L)) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (1L * 32L)), ((((4L * 32L) * (i - 1L)) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (2L * 32L)), ((((4L * 32L) * (i - 1L)) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (3L * 32L)), ((((4L * 32L) * (i - 1L)) + (4L * 32L)) - 1L)))), new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * i) + (0L * 32L)), ((((4L * 32L) * i) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * i) + (1L * 32L)), ((((4L * 32L) * i) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * i) + (2L * 32L)), ((((4L * 32L) * i) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * i) + (3L * 32L)), ((((4L * 32L) * i) + (4L * 32L)) - 1L)))), expanded_key, i, costing));
            }

#line 196 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            FinalRound.Apply((new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (0L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (1L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (2L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (3L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (4L * 32L)) - 1L)))), new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * Nr) + (0L * 32L)), ((((4L * 32L) * Nr) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * Nr) + (1L * 32L)), ((((4L * 32L) * Nr) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * Nr) + (2L * 32L)), ((((4L * 32L) * Nr) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * Nr) + (3L * 32L)), ((((4L * 32L) * Nr) + (4L * 32L)) - 1L)))), expanded_key, Nr, costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (expanded_key,state,ciphertext,Nr,Nk,costing) = __in__;
#line hidden
            FinalRound.Adjoint.Apply((new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (0L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (1L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (2L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (3L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (4L * 32L)) - 1L)))), new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * Nr) + (0L * 32L)), ((((4L * 32L) * Nr) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * Nr) + (1L * 32L)), ((((4L * 32L) * Nr) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * Nr) + (2L * 32L)), ((((4L * 32L) * Nr) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * Nr) + (3L * 32L)), ((((4L * 32L) * Nr) + (4L * 32L)) - 1L)))), expanded_key, Nr, costing));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, (Nr - 1L))))
#line hidden
            {
#line hidden
                Round.Adjoint.Apply((new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (0L * 32L)), ((((4L * 32L) * (i - 1L)) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (1L * 32L)), ((((4L * 32L) * (i - 1L)) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (2L * 32L)), ((((4L * 32L) * (i - 1L)) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (3L * 32L)), ((((4L * 32L) * (i - 1L)) + (4L * 32L)) - 1L)))), new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * i) + (0L * 32L)), ((((4L * 32L) * i) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * i) + (1L * 32L)), ((((4L * 32L) * i) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * i) + (2L * 32L)), ((((4L * 32L) * i) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * i) + (3L * 32L)), ((((4L * 32L) * i) + (4L * 32L)) - 1L)))), expanded_key, i, costing));
            }

#line hidden
            AddRoundKey.Adjoint.Apply((new QArray<IQArray<Qubit>>(state?.Slice(new Range((0L * 32L), ((1L * 32L) - 1L))), state?.Slice(new Range((1L * 32L), ((2L * 32L) - 1L))), state?.Slice(new Range((2L * 32L), ((3L * 32L) - 1L))), state?.Slice(new Range((3L * 32L), ((4L * 32L) - 1L)))), expanded_key?.Slice(new Range(0L, (4L * 32L)))));
#line hidden
            KeyExpansion.Adjoint.Apply((expanded_key, Nr, Nk, costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.AddRoundKey = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)>>(typeof(AddRoundKey));
            this.FinalRound = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean)>>(typeof(FinalRound));
            this.KeyExpansion = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Int64,Int64,Boolean)>>(typeof(KeyExpansion));
            this.Round = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean)>>(typeof(Round));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> expanded_key, IQArray<Qubit> state, IQArray<Qubit> ciphertext, Int64 Nr, Int64 Nk, Boolean costing)
        {
            return __m__.Run<ForwardRijndael, (IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean), QVoid>((expanded_key, state, ciphertext, Nr, Nk, costing));
        }
    }

    public partial class Rijndael : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean)>, ICallable
    {
        public Rijndael(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Rijndael";
        String ICallable.FullName => "QAES.Widest.Rijndael";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean)> ForwardRijndael
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>)> QUtilitiesCNOTBytes
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean), QVoid> Body => (__in__) =>
        {
            var (expanded_key,state,ciphertext,Nr,Nk,costing) = __in__;
#line 215 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            ForwardRijndael.Apply((expanded_key, state, ciphertext, Nr, Nk, costing));
#line 218 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            foreach (var j in new Range(0L, 3L))
#line hidden
            {
#line 220 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QUtilitiesCNOTBytes.Apply((state?.Slice(new Range((((4L * 32L) * Nr) + (j * 32L)), ((((4L * 32L) * Nr) + (j * 32L)) + 7L))), ciphertext?.Slice(new Range(((j * 32L) + 0L), ((j * 32L) + 7L)))));
#line 221 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QUtilitiesCNOTBytes.Apply((state?.Slice(new Range(((((4L * 32L) * Nr) + (j * 32L)) + 8L), ((((4L * 32L) * Nr) + (j * 32L)) + 15L))), ciphertext?.Slice(new Range(((j * 32L) + 8L), ((j * 32L) + 15L)))));
#line 222 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QUtilitiesCNOTBytes.Apply((state?.Slice(new Range(((((4L * 32L) * Nr) + (j * 32L)) + 16L), ((((4L * 32L) * Nr) + (j * 32L)) + 23L))), ciphertext?.Slice(new Range(((j * 32L) + 16L), ((j * 32L) + 23L)))));
#line 223 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QUtilitiesCNOTBytes.Apply((state?.Slice(new Range(((((4L * 32L) * Nr) + (j * 32L)) + 24L), ((((4L * 32L) * Nr) + (j * 32L)) + 31L))), ciphertext?.Slice(new Range(((j * 32L) + 24L), ((j * 32L) + 31L)))));
            }

#line 226 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            ForwardRijndael.Adjoint.Apply((expanded_key, state, ciphertext, Nr, Nk, costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (expanded_key,state,ciphertext,Nr,Nk,costing) = __in__;
#line hidden
            ForwardRijndael.Adjoint.Adjoint.Apply((expanded_key, state, ciphertext, Nr, Nk, costing));
#line hidden
            foreach (var j in RangeReverse.Apply(new Range(0L, 3L)))
#line hidden
            {
#line hidden
                QUtilitiesCNOTBytes.Adjoint.Apply((state?.Slice(new Range(((((4L * 32L) * Nr) + (j * 32L)) + 24L), ((((4L * 32L) * Nr) + (j * 32L)) + 31L))), ciphertext?.Slice(new Range(((j * 32L) + 24L), ((j * 32L) + 31L)))));
#line hidden
                QUtilitiesCNOTBytes.Adjoint.Apply((state?.Slice(new Range(((((4L * 32L) * Nr) + (j * 32L)) + 16L), ((((4L * 32L) * Nr) + (j * 32L)) + 23L))), ciphertext?.Slice(new Range(((j * 32L) + 16L), ((j * 32L) + 23L)))));
#line hidden
                QUtilitiesCNOTBytes.Adjoint.Apply((state?.Slice(new Range(((((4L * 32L) * Nr) + (j * 32L)) + 8L), ((((4L * 32L) * Nr) + (j * 32L)) + 15L))), ciphertext?.Slice(new Range(((j * 32L) + 8L), ((j * 32L) + 15L)))));
#line hidden
                QUtilitiesCNOTBytes.Adjoint.Apply((state?.Slice(new Range((((4L * 32L) * Nr) + (j * 32L)), ((((4L * 32L) * Nr) + (j * 32L)) + 7L))), ciphertext?.Slice(new Range(((j * 32L) + 0L), ((j * 32L) + 7L)))));
            }

#line hidden
            ForwardRijndael.Adjoint.Apply((expanded_key, state, ciphertext, Nr, Nk, costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.ForwardRijndael = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean)>>(typeof(ForwardRijndael));
            this.QUtilitiesCNOTBytes = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>)>>(typeof(QUtilities.CNOTBytes));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> expanded_key, IQArray<Qubit> state, IQArray<Qubit> ciphertext, Int64 Nr, Int64 Nk, Boolean costing)
        {
            return __m__.Run<Rijndael, (IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean), QVoid>((expanded_key, state, ciphertext, Nr, Nk, costing));
        }
    }
}

#line hidden
namespace QAES
{
    public partial class ByteSub : Adjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean)>, ICallable
    {
        public ByteSub(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean)>, IApplyData
        {
            public In((IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ByteSub";
        String ICallable.FullName => "QAES.ByteSub";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> TtypeSBox
        {
            get;
            set;
        }

        public override Func<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean), QVoid> Body => (__in__) =>
        {
            var (input_state,ancilla,costing) = __in__;
#line 12 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            foreach (var i in new Range(0L, 3L))
#line hidden
            {
#line 14 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                foreach (var j in new Range(0L, 3L))
#line hidden
                {
#line 17 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    TtypeSBox.Apply((input_state[j]?.Slice(new Range((i * 8L), (((i + 1L) * 8L) - 1L))), ancilla[j]?.Slice(new Range((i * 8L), (((i + 1L) * 8L) - 1L))), costing));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (input_state,ancilla,costing) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, 3L)))
#line hidden
            {
#line hidden
                foreach (var j in RangeReverse.Apply(new Range(0L, 3L)))
#line hidden
                {
#line hidden
                    TtypeSBox.Adjoint.Apply((input_state[j]?.Slice(new Range((i * 8L), (((i + 1L) * 8L) - 1L))), ancilla[j]?.Slice(new Range((i * 8L), (((i + 1L) * 8L) - 1L))), costing));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.TtypeSBox = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(Ttype.SBox));
        }

        public override IApplyData __dataIn((IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<IQArray<Qubit>> input_state, IQArray<IQArray<Qubit>> ancilla, Boolean costing)
        {
            return __m__.Run<ByteSub, (IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean), QVoid>((input_state, ancilla, costing));
        }
    }

    public partial class SubByte : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public SubByte(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "SubByte";
        String ICallable.FullName => "QAES.SubByte";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> TtypeSBox1
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (input_word,ancilla,costing) = __in__;
#line 29 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            foreach (var i in new Range(0L, 3L))
#line hidden
            {
#line 32 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                TtypeSBox1.Apply((input_word?.Slice(new Range((i * 8L), (((i + 1L) * 8L) - 1L))), ancilla?.Slice(new Range((i * 8L), (((i + 1L) * 8L) - 1L))), costing));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (input_word,ancilla,costing) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, 3L)))
#line hidden
            {
#line hidden
                TtypeSBox1.Adjoint.Apply((input_word?.Slice(new Range((i * 8L), (((i + 1L) * 8L) - 1L))), ancilla?.Slice(new Range((i * 8L), (((i + 1L) * 8L) - 1L))), costing));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.TtypeSBox1 = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(Ttype.SBox1));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> input_word, IQArray<Qubit> ancilla, Boolean costing)
        {
            return __m__.Run<SubByte, (IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((input_word, ancilla, costing));
        }
    }
}

#line hidden
namespace QAES.SmartWide
{
    public partial class Round : Adjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean)>, ICallable
    {
        public Round(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean)>, IApplyData
        {
            public In((IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Round";
        String ICallable.FullName => "QAES.SmartWide.Round";
        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Int64,Int64,Boolean)> MaximovMixColumnMixColumn
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean)> QAESByteSub
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean)> QAESInPlaceKeyExpansion
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)> QAESInPlaceMixColumn
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)> QAESInPlaceShiftRow
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)> QAESWidestAddRoundKey
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)> QUtilitiesCNOTnBits
        {
            get;
            set;
        }

        public override Func<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean), QVoid> Body => (__in__) =>
        {
            var (in_state,out_state,key,round,Nk,in_place_mixcolumn,costing) = __in__;
#line 243 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QAESByteSub.Apply((in_state, out_state?.Slice(new Range(0L, 3L)), costing));
#line 244 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QAESInPlaceShiftRow.Apply((out_state, costing));
#line 245 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            if (in_place_mixcolumn)
            {
#line 247 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QAESInPlaceMixColumn.Apply((out_state, costing));
            }
            else
            {
#line 251 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                MaximovMixColumnMixColumn.Apply((out_state?.Slice(new Range(0L, 3L)), out_state?.Slice(new Range(4L, 7L)), 0L, 3L, costing));
            }

#line 254 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            if ((Nk == 4L))
            {
#line 257 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QAESInPlaceKeyExpansion.Apply((key, round, Nk, 0L, (Nk - 1L), costing));
#line 258 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QAESWidestAddRoundKey.Apply((out_state?.Slice(new Range((0L + (in_place_mixcolumn ? 0L : 4L)), (3L + (in_place_mixcolumn ? 0L : 4L)))), key));
            }
            else if ((Nk == 6L))
            {
#line 263 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                if (((round % 3L) == 1L))
                {
#line 266 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    var key_round = (((round / 3L) * 2L) + 1L);
#line 267 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    if ((round > 1L))
                    {
#line 269 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        QAESInPlaceKeyExpansion.Apply((key, key_round, Nk, ((2L * Nk) / 3L), (Nk - 1L), costing));
                    }

#line 271 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QAESInPlaceKeyExpansion.Apply((key, key_round, Nk, 0L, 1L, costing));
#line 272 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QUtilitiesCNOTnBits.Apply((key?.Slice(new Range((4L * 32L), ((5L * 32L) - 1L))), out_state[(0L + (in_place_mixcolumn ? 0L : 4L))], 32L));
#line 273 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QUtilitiesCNOTnBits.Apply((key?.Slice(new Range((5L * 32L), ((6L * 32L) - 1L))), out_state[(1L + (in_place_mixcolumn ? 0L : 4L))], 32L));
#line 274 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QUtilitiesCNOTnBits.Apply((key?.Slice(new Range((0L * 32L), ((1L * 32L) - 1L))), out_state[(2L + (in_place_mixcolumn ? 0L : 4L))], 32L));
#line 275 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QUtilitiesCNOTnBits.Apply((key?.Slice(new Range((1L * 32L), ((2L * 32L) - 1L))), out_state[(3L + (in_place_mixcolumn ? 0L : 4L))], 32L));
                }
                else if (((round % 3L) == 2L))
                {
#line 279 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    var key_round = (((round / 3L) * 2L) + 1L);
#line 280 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QAESInPlaceKeyExpansion.Apply((key, key_round, Nk, 2L, (Nk - 1L), costing));
#line 281 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QAESWidestAddRoundKey.Apply((out_state?.Slice(new Range((0L + (in_place_mixcolumn ? 0L : 4L)), (3L + (in_place_mixcolumn ? 0L : 4L)))), key?.Slice(new Range((2L * 32L), ((6L * 32L) - 1L)))));
                }
                else
                {
#line 285 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    var key_round = ((round / 3L) * 2L);
#line 286 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QAESInPlaceKeyExpansion.Apply((key, key_round, Nk, 0L, (((2L * Nk) / 3L) - 1L), costing));
#line 287 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QAESWidestAddRoundKey.Apply((out_state?.Slice(new Range((0L + (in_place_mixcolumn ? 0L : 4L)), (3L + (in_place_mixcolumn ? 0L : 4L)))), key?.Slice(new Range((0L * 32L), ((4L * 32L) - 1L)))));
                }
            }
            else if ((Nk == 8L))
            {
#line 293 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                if (((round % 2L) == 0L))
                {
#line 295 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    var key_round = (round / 2L);
#line 296 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QAESInPlaceKeyExpansion.Apply((key, key_round, Nk, 0L, ((Nk / 2L) - 1L), costing));
#line 297 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QAESWidestAddRoundKey.Apply((out_state?.Slice(new Range((0L + (in_place_mixcolumn ? 0L : 4L)), (3L + (in_place_mixcolumn ? 0L : 4L)))), key?.Slice(new Range((0L * 32L), ((4L * 32L) - 1L)))));
                }
                else
                {
#line 301 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    if ((round > 2L))
                    {
#line 303 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        var key_round = (round / 2L);
#line 304 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                        QAESInPlaceKeyExpansion.Apply((key, key_round, Nk, (Nk / 2L), (Nk - 1L), costing));
                    }

#line 306 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                    QAESWidestAddRoundKey.Apply((out_state?.Slice(new Range((0L + (in_place_mixcolumn ? 0L : 4L)), (3L + (in_place_mixcolumn ? 0L : 4L)))), key?.Slice(new Range((4L * 32L), ((8L * 32L) - 1L)))));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (in_state,out_state,key,round,Nk,in_place_mixcolumn,costing) = __in__;
#line hidden
            if ((Nk == 4L))
            {
#line hidden
                QAESWidestAddRoundKey.Adjoint.Apply((out_state?.Slice(new Range((0L + (in_place_mixcolumn ? 0L : 4L)), (3L + (in_place_mixcolumn ? 0L : 4L)))), key));
#line hidden
                QAESInPlaceKeyExpansion.Adjoint.Apply((key, round, Nk, 0L, (Nk - 1L), costing));
            }
            else if ((Nk == 6L))
            {
#line hidden
                if (((round % 3L) == 1L))
                {
#line hidden
                    var key_round = (((round / 3L) * 2L) + 1L);
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((key?.Slice(new Range((1L * 32L), ((2L * 32L) - 1L))), out_state[(3L + (in_place_mixcolumn ? 0L : 4L))], 32L));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((key?.Slice(new Range((0L * 32L), ((1L * 32L) - 1L))), out_state[(2L + (in_place_mixcolumn ? 0L : 4L))], 32L));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((key?.Slice(new Range((5L * 32L), ((6L * 32L) - 1L))), out_state[(1L + (in_place_mixcolumn ? 0L : 4L))], 32L));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((key?.Slice(new Range((4L * 32L), ((5L * 32L) - 1L))), out_state[(0L + (in_place_mixcolumn ? 0L : 4L))], 32L));
#line hidden
                    QAESInPlaceKeyExpansion.Adjoint.Apply((key, key_round, Nk, 0L, 1L, costing));
#line hidden
                    if ((round > 1L))
                    {
#line hidden
                        QAESInPlaceKeyExpansion.Adjoint.Apply((key, key_round, Nk, ((2L * Nk) / 3L), (Nk - 1L), costing));
                    }
                }
                else if (((round % 3L) == 2L))
                {
#line hidden
                    var key_round = (((round / 3L) * 2L) + 1L);
#line hidden
                    QAESWidestAddRoundKey.Adjoint.Apply((out_state?.Slice(new Range((0L + (in_place_mixcolumn ? 0L : 4L)), (3L + (in_place_mixcolumn ? 0L : 4L)))), key?.Slice(new Range((2L * 32L), ((6L * 32L) - 1L)))));
#line hidden
                    QAESInPlaceKeyExpansion.Adjoint.Apply((key, key_round, Nk, 2L, (Nk - 1L), costing));
                }
                else
                {
#line hidden
                    var key_round = ((round / 3L) * 2L);
#line hidden
                    QAESWidestAddRoundKey.Adjoint.Apply((out_state?.Slice(new Range((0L + (in_place_mixcolumn ? 0L : 4L)), (3L + (in_place_mixcolumn ? 0L : 4L)))), key?.Slice(new Range((0L * 32L), ((4L * 32L) - 1L)))));
#line hidden
                    QAESInPlaceKeyExpansion.Adjoint.Apply((key, key_round, Nk, 0L, (((2L * Nk) / 3L) - 1L), costing));
                }
            }
            else if ((Nk == 8L))
            {
#line hidden
                if (((round % 2L) == 0L))
                {
#line hidden
                    var key_round = (round / 2L);
#line hidden
                    QAESWidestAddRoundKey.Adjoint.Apply((out_state?.Slice(new Range((0L + (in_place_mixcolumn ? 0L : 4L)), (3L + (in_place_mixcolumn ? 0L : 4L)))), key?.Slice(new Range((0L * 32L), ((4L * 32L) - 1L)))));
#line hidden
                    QAESInPlaceKeyExpansion.Adjoint.Apply((key, key_round, Nk, 0L, ((Nk / 2L) - 1L), costing));
                }
                else
                {
#line hidden
                    QAESWidestAddRoundKey.Adjoint.Apply((out_state?.Slice(new Range((0L + (in_place_mixcolumn ? 0L : 4L)), (3L + (in_place_mixcolumn ? 0L : 4L)))), key?.Slice(new Range((4L * 32L), ((8L * 32L) - 1L)))));
#line hidden
                    if ((round > 2L))
                    {
#line hidden
                        var key_round = (round / 2L);
#line hidden
                        QAESInPlaceKeyExpansion.Adjoint.Apply((key, key_round, Nk, (Nk / 2L), (Nk - 1L), costing));
                    }
                }
            }

#line hidden
            if (in_place_mixcolumn)
            {
#line hidden
                QAESInPlaceMixColumn.Adjoint.Apply((out_state, costing));
            }
            else
            {
#line hidden
                MaximovMixColumnMixColumn.Adjoint.Apply((out_state?.Slice(new Range(0L, 3L)), out_state?.Slice(new Range(4L, 7L)), 0L, 3L, costing));
            }

#line hidden
            QAESInPlaceShiftRow.Adjoint.Apply((out_state, costing));
#line hidden
            QAESByteSub.Adjoint.Apply((in_state, out_state?.Slice(new Range(0L, 3L)), costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MaximovMixColumnMixColumn = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Int64,Int64,Boolean)>>(typeof(MaximovMixColumn.MixColumn));
            this.QAESByteSub = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean)>>(typeof(QAES.ByteSub));
            this.QAESInPlaceKeyExpansion = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean)>>(typeof(QAES.InPlace.KeyExpansion));
            this.QAESInPlaceMixColumn = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)>>(typeof(QAES.InPlace.MixColumn));
            this.QAESInPlaceShiftRow = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)>>(typeof(QAES.InPlace.ShiftRow));
            this.QAESWidestAddRoundKey = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)>>(typeof(QAES.Widest.AddRoundKey));
            this.QUtilitiesCNOTnBits = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)>>(typeof(QUtilities.CNOTnBits));
        }

        public override IApplyData __dataIn((IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<IQArray<Qubit>> in_state, IQArray<IQArray<Qubit>> out_state, IQArray<Qubit> key, Int64 round, Int64 Nk, Boolean in_place_mixcolumn, Boolean costing)
        {
            return __m__.Run<Round, (IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean), QVoid>((in_state, out_state, key, round, Nk, in_place_mixcolumn, costing));
        }
    }

    public partial class FinalRound : Adjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean)>, ICallable
    {
        public FinalRound(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean)>, IApplyData
        {
            public In((IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "FinalRound";
        String ICallable.FullName => "QAES.SmartWide.FinalRound";
        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean)> QAESByteSub
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean)> QAESInPlaceKeyExpansion
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)> QAESInPlaceShiftRow
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)> QAESWidestAddRoundKey
        {
            get;
            set;
        }

        public override Func<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean), QVoid> Body => (__in__) =>
        {
            var (in_state,out_state,key,round,Nk,costing) = __in__;
#line 317 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QAESByteSub.Apply((in_state, out_state, costing));
#line 318 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QAESInPlaceShiftRow.Apply((out_state, costing));
#line 319 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            if ((Nk == 4L))
            {
#line 324 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QAESInPlaceKeyExpansion.Apply((key, round, Nk, 0L, (Nk - 1L), costing));
#line 325 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QAESWidestAddRoundKey.Apply((out_state, key));
            }
            else if ((Nk == 6L))
            {
#line 330 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                var key_round = ((round / 3L) * 2L);
#line 332 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QAESInPlaceKeyExpansion.Apply((key, key_round, Nk, 0L, (Nk - 3L), costing));
#line 333 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QAESWidestAddRoundKey.Apply((out_state, key?.Slice(new Range((0L * 32L), ((4L * 32L) - 1L)))));
            }
            else if ((Nk == 8L))
            {
#line 339 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                var key_round = (round / 2L);
#line 340 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QAESInPlaceKeyExpansion.Apply((key, key_round, Nk, 0L, ((Nk / 2L) - 1L), costing));
#line 341 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                QAESWidestAddRoundKey.Apply((out_state, key?.Slice(new Range((0L * 32L), ((4L * 32L) - 1L)))));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (in_state,out_state,key,round,Nk,costing) = __in__;
#line hidden
            if ((Nk == 4L))
            {
#line hidden
                QAESWidestAddRoundKey.Adjoint.Apply((out_state, key));
#line hidden
                QAESInPlaceKeyExpansion.Adjoint.Apply((key, round, Nk, 0L, (Nk - 1L), costing));
            }
            else if ((Nk == 6L))
            {
#line hidden
                var key_round = ((round / 3L) * 2L);
#line hidden
                QAESWidestAddRoundKey.Adjoint.Apply((out_state, key?.Slice(new Range((0L * 32L), ((4L * 32L) - 1L)))));
#line hidden
                QAESInPlaceKeyExpansion.Adjoint.Apply((key, key_round, Nk, 0L, (Nk - 3L), costing));
            }
            else if ((Nk == 8L))
            {
#line hidden
                var key_round = (round / 2L);
#line hidden
                QAESWidestAddRoundKey.Adjoint.Apply((out_state, key?.Slice(new Range((0L * 32L), ((4L * 32L) - 1L)))));
#line hidden
                QAESInPlaceKeyExpansion.Adjoint.Apply((key, key_round, Nk, 0L, ((Nk / 2L) - 1L), costing));
            }

#line hidden
            QAESInPlaceShiftRow.Adjoint.Apply((out_state, costing));
#line hidden
            QAESByteSub.Adjoint.Apply((in_state, out_state, costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QAESByteSub = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean)>>(typeof(QAES.ByteSub));
            this.QAESInPlaceKeyExpansion = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean)>>(typeof(QAES.InPlace.KeyExpansion));
            this.QAESInPlaceShiftRow = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)>>(typeof(QAES.InPlace.ShiftRow));
            this.QAESWidestAddRoundKey = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)>>(typeof(QAES.Widest.AddRoundKey));
        }

        public override IApplyData __dataIn((IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<IQArray<Qubit>> in_state, IQArray<IQArray<Qubit>> out_state, IQArray<Qubit> key, Int64 round, Int64 Nk, Boolean costing)
        {
            return __m__.Run<FinalRound, (IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean), QVoid>((in_state, out_state, key, round, Nk, costing));
        }
    }

    public partial class ForwardRijndael : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean)>, ICallable
    {
        public ForwardRijndael(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "ForwardRijndael";
        String ICallable.FullName => "QAES.SmartWide.ForwardRijndael";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean)> FinalRound
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean)> Round
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)> QAESWidestAddRoundKey
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean), QVoid> Body => (__in__) =>
        {
            var (key,state,Nr,Nk,in_place_mixcolumn,costing) = __in__;
#line 352 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QAESWidestAddRoundKey.Apply((new QArray<IQArray<Qubit>>(state?.Slice(new Range((0L * 32L), ((1L * 32L) - 1L))), state?.Slice(new Range((1L * 32L), ((2L * 32L) - 1L))), state?.Slice(new Range((2L * 32L), ((3L * 32L) - 1L))), state?.Slice(new Range((3L * 32L), ((4L * 32L) - 1L)))), key));
#line 359 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            foreach (var i in new Range(1L, (Nr - 1L)))
#line hidden
            {
#line 362 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
                Round.Apply(((in_place_mixcolumn ? new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (0L * 32L)), ((((4L * 32L) * (i - 1L)) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (1L * 32L)), ((((4L * 32L) * (i - 1L)) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (2L * 32L)), ((((4L * 32L) * (i - 1L)) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (3L * 32L)), ((((4L * 32L) * (i - 1L)) + (4L * 32L)) - 1L)))) : new QArray<IQArray<Qubit>>(state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (0L * 32L)), ((((8L * 32L) * (i - 1L)) + (1L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (1L * 32L)), ((((8L * 32L) * (i - 1L)) + (2L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (2L * 32L)), ((((8L * 32L) * (i - 1L)) + (3L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (3L * 32L)), ((((8L * 32L) * (i - 1L)) + (4L * 32L)) - 1L))))), (in_place_mixcolumn ? new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * i) + (0L * 32L)), ((((4L * 32L) * i) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * i) + (1L * 32L)), ((((4L * 32L) * i) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * i) + (2L * 32L)), ((((4L * 32L) * i) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * i) + (3L * 32L)), ((((4L * 32L) * i) + (4L * 32L)) - 1L)))) : new QArray<IQArray<Qubit>>(state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (4L * 32L)), ((((8L * 32L) * (i - 1L)) + (5L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (5L * 32L)), ((((8L * 32L) * (i - 1L)) + (6L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (6L * 32L)), ((((8L * 32L) * (i - 1L)) + (7L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (7L * 32L)), ((((8L * 32L) * (i - 1L)) + (8L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (8L * 32L)), ((((8L * 32L) * (i - 1L)) + (9L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (9L * 32L)), ((((8L * 32L) * (i - 1L)) + (10L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (10L * 32L)), ((((8L * 32L) * (i - 1L)) + (11L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (11L * 32L)), ((((8L * 32L) * (i - 1L)) + (12L * 32L)) - 1L))))), key, i, Nk, in_place_mixcolumn, costing));
            }

#line 390 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            FinalRound.Apply(((in_place_mixcolumn ? new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (0L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (1L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (2L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (3L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (4L * 32L)) - 1L)))) : new QArray<IQArray<Qubit>>(state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (0L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (1L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (1L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (2L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (2L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (3L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (3L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (4L * 32L)) - 1L))))), (in_place_mixcolumn ? new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * Nr) + (0L * 32L)), ((((4L * 32L) * Nr) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * Nr) + (1L * 32L)), ((((4L * 32L) * Nr) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * Nr) + (2L * 32L)), ((((4L * 32L) * Nr) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * Nr) + (3L * 32L)), ((((4L * 32L) * Nr) + (4L * 32L)) - 1L)))) : new QArray<IQArray<Qubit>>(state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (4L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (5L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (5L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (6L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (6L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (7L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (7L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (8L * 32L)) - 1L))))), key, Nr, Nk, costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (key,state,Nr,Nk,in_place_mixcolumn,costing) = __in__;
#line hidden
            FinalRound.Adjoint.Apply(((in_place_mixcolumn ? new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (0L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (1L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (2L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (Nr - 1L)) + (3L * 32L)), ((((4L * 32L) * (Nr - 1L)) + (4L * 32L)) - 1L)))) : new QArray<IQArray<Qubit>>(state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (0L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (1L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (1L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (2L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (2L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (3L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (3L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (4L * 32L)) - 1L))))), (in_place_mixcolumn ? new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * Nr) + (0L * 32L)), ((((4L * 32L) * Nr) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * Nr) + (1L * 32L)), ((((4L * 32L) * Nr) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * Nr) + (2L * 32L)), ((((4L * 32L) * Nr) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * Nr) + (3L * 32L)), ((((4L * 32L) * Nr) + (4L * 32L)) - 1L)))) : new QArray<IQArray<Qubit>>(state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (4L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (5L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (5L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (6L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (6L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (7L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (7L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (8L * 32L)) - 1L))))), key, Nr, Nk, costing));
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, (Nr - 1L))))
#line hidden
            {
#line hidden
                Round.Adjoint.Apply(((in_place_mixcolumn ? new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (0L * 32L)), ((((4L * 32L) * (i - 1L)) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (1L * 32L)), ((((4L * 32L) * (i - 1L)) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (2L * 32L)), ((((4L * 32L) * (i - 1L)) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * (i - 1L)) + (3L * 32L)), ((((4L * 32L) * (i - 1L)) + (4L * 32L)) - 1L)))) : new QArray<IQArray<Qubit>>(state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (0L * 32L)), ((((8L * 32L) * (i - 1L)) + (1L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (1L * 32L)), ((((8L * 32L) * (i - 1L)) + (2L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (2L * 32L)), ((((8L * 32L) * (i - 1L)) + (3L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (3L * 32L)), ((((8L * 32L) * (i - 1L)) + (4L * 32L)) - 1L))))), (in_place_mixcolumn ? new QArray<IQArray<Qubit>>(state?.Slice(new Range((((4L * 32L) * i) + (0L * 32L)), ((((4L * 32L) * i) + (1L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * i) + (1L * 32L)), ((((4L * 32L) * i) + (2L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * i) + (2L * 32L)), ((((4L * 32L) * i) + (3L * 32L)) - 1L))), state?.Slice(new Range((((4L * 32L) * i) + (3L * 32L)), ((((4L * 32L) * i) + (4L * 32L)) - 1L)))) : new QArray<IQArray<Qubit>>(state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (4L * 32L)), ((((8L * 32L) * (i - 1L)) + (5L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (5L * 32L)), ((((8L * 32L) * (i - 1L)) + (6L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (6L * 32L)), ((((8L * 32L) * (i - 1L)) + (7L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (7L * 32L)), ((((8L * 32L) * (i - 1L)) + (8L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (8L * 32L)), ((((8L * 32L) * (i - 1L)) + (9L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (9L * 32L)), ((((8L * 32L) * (i - 1L)) + (10L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (10L * 32L)), ((((8L * 32L) * (i - 1L)) + (11L * 32L)) - 1L))), state?.Slice(new Range((((8L * 32L) * (i - 1L)) + (11L * 32L)), ((((8L * 32L) * (i - 1L)) + (12L * 32L)) - 1L))))), key, i, Nk, in_place_mixcolumn, costing));
            }

#line hidden
            QAESWidestAddRoundKey.Adjoint.Apply((new QArray<IQArray<Qubit>>(state?.Slice(new Range((0L * 32L), ((1L * 32L) - 1L))), state?.Slice(new Range((1L * 32L), ((2L * 32L) - 1L))), state?.Slice(new Range((2L * 32L), ((3L * 32L) - 1L))), state?.Slice(new Range((3L * 32L), ((4L * 32L) - 1L)))), key));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.FinalRound = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean)>>(typeof(FinalRound));
            this.Round = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean)>>(typeof(Round));
            this.QAESWidestAddRoundKey = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)>>(typeof(QAES.Widest.AddRoundKey));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> key, IQArray<Qubit> state, Int64 Nr, Int64 Nk, Boolean in_place_mixcolumn, Boolean costing)
        {
            return __m__.Run<ForwardRijndael, (IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean), QVoid>((key, state, Nr, Nk, in_place_mixcolumn, costing));
        }
    }

    public partial class Rijndael : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean)>, ICallable
    {
        public Rijndael(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Rijndael";
        String ICallable.FullName => "QAES.SmartWide.Rijndael";
        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean)> ForwardRijndael
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)> QUtilitiesCNOTnBits
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean), QVoid> Body => (__in__) =>
        {
            var (key,state,ciphertext,Nr,Nk,in_place_mixcolumn,costing) = __in__;
#line 421 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            ForwardRijndael.Apply((key, state, Nr, Nk, in_place_mixcolumn, costing));
#line 424 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesCNOTnBits.Apply(((in_place_mixcolumn ? state?.Slice(new Range((((4L * 32L) * Nr) + (0L * 32L)), ((((4L * 32L) * Nr) + (1L * 32L)) - 1L))) : state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (4L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (5L * 32L)) - 1L)))), ciphertext?.Slice(new Range(0L, 31L)), 32L));
#line 425 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesCNOTnBits.Apply(((in_place_mixcolumn ? state?.Slice(new Range((((4L * 32L) * Nr) + (1L * 32L)), ((((4L * 32L) * Nr) + (2L * 32L)) - 1L))) : state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (5L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (6L * 32L)) - 1L)))), ciphertext?.Slice(new Range(32L, 63L)), 32L));
#line 426 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesCNOTnBits.Apply(((in_place_mixcolumn ? state?.Slice(new Range((((4L * 32L) * Nr) + (2L * 32L)), ((((4L * 32L) * Nr) + (3L * 32L)) - 1L))) : state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (6L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (7L * 32L)) - 1L)))), ciphertext?.Slice(new Range(64L, 95L)), 32L));
#line 427 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            QUtilitiesCNOTnBits.Apply(((in_place_mixcolumn ? state?.Slice(new Range((((4L * 32L) * Nr) + (3L * 32L)), ((((4L * 32L) * Nr) + (4L * 32L)) - 1L))) : state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (7L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (8L * 32L)) - 1L)))), ciphertext?.Slice(new Range(96L, 127L)), 32L));
#line 429 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QAES.qs"
            ForwardRijndael.Adjoint.Apply((key, state, Nr, Nk, in_place_mixcolumn, costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (key,state,ciphertext,Nr,Nk,in_place_mixcolumn,costing) = __in__;
#line hidden
            ForwardRijndael.Adjoint.Adjoint.Apply((key, state, Nr, Nk, in_place_mixcolumn, costing));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply(((in_place_mixcolumn ? state?.Slice(new Range((((4L * 32L) * Nr) + (3L * 32L)), ((((4L * 32L) * Nr) + (4L * 32L)) - 1L))) : state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (7L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (8L * 32L)) - 1L)))), ciphertext?.Slice(new Range(96L, 127L)), 32L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply(((in_place_mixcolumn ? state?.Slice(new Range((((4L * 32L) * Nr) + (2L * 32L)), ((((4L * 32L) * Nr) + (3L * 32L)) - 1L))) : state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (6L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (7L * 32L)) - 1L)))), ciphertext?.Slice(new Range(64L, 95L)), 32L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply(((in_place_mixcolumn ? state?.Slice(new Range((((4L * 32L) * Nr) + (1L * 32L)), ((((4L * 32L) * Nr) + (2L * 32L)) - 1L))) : state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (5L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (6L * 32L)) - 1L)))), ciphertext?.Slice(new Range(32L, 63L)), 32L));
#line hidden
            QUtilitiesCNOTnBits.Adjoint.Apply(((in_place_mixcolumn ? state?.Slice(new Range((((4L * 32L) * Nr) + (0L * 32L)), ((((4L * 32L) * Nr) + (1L * 32L)) - 1L))) : state?.Slice(new Range((((8L * 32L) * (Nr - 1L)) + (4L * 32L)), ((((8L * 32L) * (Nr - 1L)) + (5L * 32L)) - 1L)))), ciphertext?.Slice(new Range(0L, 31L)), 32L));
#line hidden
            ForwardRijndael.Adjoint.Apply((key, state, Nr, Nk, in_place_mixcolumn, costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.ForwardRijndael = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean)>>(typeof(ForwardRijndael));
            this.QUtilitiesCNOTnBits = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)>>(typeof(QUtilities.CNOTnBits));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> key, IQArray<Qubit> state, IQArray<Qubit> ciphertext, Int64 Nr, Int64 Nk, Boolean in_place_mixcolumn, Boolean costing)
        {
            return __m__.Run<Rijndael, (IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean), QVoid>((key, state, ciphertext, Nr, Nk, in_place_mixcolumn, costing));
        }
    }
}