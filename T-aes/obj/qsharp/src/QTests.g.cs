#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.Utilities\",\"Name\":\"AND\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":738,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":27}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.Utilities\",\"Name\":\"AND\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":738,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.Utilities\",\"Name\":\"ANDadj\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":758,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":30}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.Utilities\",\"Name\":\"ANDadj\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":758,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"SBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":18}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"tower_field\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"LPS19\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"SBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"ShiftRow\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"ShiftRow\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"MixWord\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":95,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_word\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":59}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"MixWord\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":95,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"MixColumn\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":136,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":62}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"MixColumn\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":136,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"ByteSub\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":217,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_input_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"ByteSub\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":217,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"AddRoundKey\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":279,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_round_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"AddRoundKey\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":279,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"KeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":341,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":65}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"KeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":341,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"InPlacePartialKeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":368,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":65}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"kexp_round\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":72},\"Item2\":{\"Line\":1,\"Column\":82}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"low\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":89},\"Item2\":{\"Line\":1,\"Column\":92}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"high\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":99},\"Item2\":{\"Line\":1,\"Column\":103}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":110},\"Item2\":{\"Line\":1,\"Column\":117}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"InPlacePartialKeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":368,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"InPlaceKeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":395,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":58}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"InPlaceKeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":395,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"Round\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":440,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_round_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"round\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":62}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"smart_wide\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":79}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":87},\"Item2\":{\"Line\":1,\"Column\":89}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place_mixcolumn\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":96},\"Item2\":{\"Line\":1,\"Column\":114}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":122},\"Item2\":{\"Line\":1,\"Column\":129}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Int\"},{\"Case\":\"Bool\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"Round\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":440,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"FinalRound\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":519,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_round_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"smart_wide\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":72}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":80},\"Item2\":{\"Line\":1,\"Column\":82}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":89},\"Item2\":{\"Line\":1,\"Column\":96}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"FinalRound\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":519,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"WideRijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":593,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_message\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":62}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":71}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place_mixcolumn\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":96}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":104},\"Item2\":{\"Line\":1,\"Column\":111}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"WideRijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":593,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"SmartWideRijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":661,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_message\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":53}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":67}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":74},\"Item2\":{\"Line\":1,\"Column\":76}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place_mixcolumn\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":83},\"Item2\":{\"Line\":1,\"Column\":101}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":109},\"Item2\":{\"Line\":1,\"Column\":116}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"SmartWideRijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":661,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
#line hidden
namespace QTests.Utilities
{
    public partial class AND : Operation<(Result,Result), Result>, ICallable
    {
        public AND(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Result)>, IApplyData
        {
            public In((Result,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AND";
        String ICallable.FullName => "QTests.Utilities.AND";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit)> QUtilitiesAND
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(Result,Result), Result> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 741 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res = Result.Zero;
#line hidden
            {
#line 742 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var (a,b,c) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 744 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((x, a));
#line 745 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((y, b));
#line 747 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QUtilitiesAND.Apply((a, b, c));
#line 749 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    res = MicrosoftQuantumIntrinsicM.Apply(c);
#line 752 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((Result.Zero, a));
#line 753 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((Result.Zero, b));
#line 754 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((Result.Zero, c));
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
                    Release.Apply(a);
#line hidden
                    Release.Apply(b);
#line hidden
                    Release.Apply(c);
                }
            }

#line 756 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QUtilitiesAND = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(QUtilities.AND));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((Result,Result) data) => new In(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Result x, Result y)
        {
            return __m__.Run<AND, (Result,Result), Result>((x, y));
        }
    }

    public partial class ANDadj : Operation<(Result,Result), Result>, ICallable
    {
        public ANDadj(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Result)>, IApplyData
        {
            public In((Result,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ANDadj";
        String ICallable.FullName => "QTests.Utilities.ANDadj";
        protected ICallable<Boolean, Result> MicrosoftQuantumConvertBoolAsResult
        {
            get;
            set;
        }

        protected ICallable<Result, Boolean> MicrosoftQuantumConvertResultAsBool
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit)> QUtilitiesAND
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(Result,Result), Result> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 761 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res = Result.Zero;
#line hidden
            {
#line 762 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var (a,b,c) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 764 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((x, a));
#line 765 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((y, b));
#line 766 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((MicrosoftQuantumConvertBoolAsResult.Apply((MicrosoftQuantumConvertResultAsBool.Apply(x) && MicrosoftQuantumConvertResultAsBool.Apply(y))), c));
#line 768 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QUtilitiesAND.Adjoint.Apply((a, b, c));
#line 770 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    res = MicrosoftQuantumIntrinsicM.Apply(c);
#line 773 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((Result.Zero, a));
#line 774 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((Result.Zero, b));
#line 775 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((Result.Zero, c));
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
                    Release.Apply(a);
#line hidden
                    Release.Apply(b);
#line hidden
                    Release.Apply(c);
                }
            }

#line 777 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumConvertBoolAsResult = this.Factory.Get<ICallable<Boolean, Result>>(typeof(Microsoft.Quantum.Convert.BoolAsResult));
            this.MicrosoftQuantumConvertResultAsBool = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Convert.ResultAsBool));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QUtilitiesAND = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(QUtilities.AND));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((Result,Result) data) => new In(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, Result x, Result y)
        {
            return __m__.Run<ANDadj, (Result,Result), Result>((x, y));
        }
    }
}

#line hidden
namespace QTests.AES
{
    public partial class SBox : Operation<(IQArray<Result>,Boolean,Boolean,Boolean), IQArray<Result>>, ICallable
    {
        public SBox(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,Boolean,Boolean,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,Boolean,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "SBox";
        String ICallable.FullName => "QTests.AES.SBox";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> TtypeSBox
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,Boolean,Boolean,Boolean), IQArray<Result>> Body => (__in__) =>
        {
            var (_a,tower_field,LPS19,costing) = __in__;
#line 13 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(8L);
#line hidden
            {
#line 14 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var (a,b) = (Allocate.Apply(8L), Allocate.Apply(8L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 16 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 18 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_a[(i - 1L)], a[(i - 1L)]));
                    }

#line 21 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    TtypeSBox.Apply((a, b, costing));
#line 29 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 31 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res.Modify((i - 1L), MicrosoftQuantumIntrinsicM.Apply(b[(i - 1L)]));
                    }

#line 35 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 37 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, a[(i - 1L)]));
#line 38 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, b[(i - 1L)]));
                    }
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
                    Release.Apply(a);
#line hidden
                    Release.Apply(b);
                }
            }

#line 41 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
            this.TtypeSBox = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(Ttype.SBox));
        }

        public override IApplyData __dataIn((IQArray<Result>,Boolean,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, IQArray<Result> _a, Boolean tower_field, Boolean LPS19, Boolean costing)
        {
            return __m__.Run<SBox, (IQArray<Result>,Boolean,Boolean,Boolean), IQArray<Result>>((_a, tower_field, LPS19, costing));
        }
    }

    public partial class ShiftRow : Operation<(IQArray<Result>,Boolean), IQArray<IQArray<Result>>>, ICallable
    {
        public ShiftRow(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ShiftRow";
        String ICallable.FullName => "QTests.AES.ShiftRow";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)> QAESInPlaceShiftRow
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,Boolean), IQArray<IQArray<Result>>> Body => (__in__) =>
        {
            var (_state,costing) = __in__;
#line 46 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 47 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 48 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 49 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 51 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var (state_1,state_2,state_3,state_4) = (Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 53 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    var state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(state_1, state_2, state_3, state_4);
#line 54 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 56 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 58 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_state[((j * 32L) + i)], state[j][i]));
                        }
                    }

#line 62 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QAESInPlaceShiftRow.Apply((state, costing));
#line 64 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 66 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[0L][i]));
                    }

#line 69 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 71 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[1L][i]));
                    }

#line 74 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 76 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[2L][i]));
                    }

#line 79 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 81 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[3L][i]));
                    }

#line 85 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 87 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 89 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, state[j][i]));
                        }
                    }
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
                    Release.Apply(state_1);
#line hidden
                    Release.Apply(state_2);
#line hidden
                    Release.Apply(state_3);
#line hidden
                    Release.Apply(state_4);
                }
            }

#line 93 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return new QArray<IQArray<Result>>(res_1?.Copy(), res_2?.Copy(), res_3?.Copy(), res_4?.Copy());
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QAESInPlaceShiftRow = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)>>(typeof(QAES.InPlace.ShiftRow));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<IQArray<Result>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Result>>> Run(IOperationFactory __m__, IQArray<Result> _state, Boolean costing)
        {
            return __m__.Run<ShiftRow, (IQArray<Result>,Boolean), IQArray<IQArray<Result>>>((_state, costing));
        }
    }

    public partial class MixWord : Operation<(IQArray<Result>,Boolean,Boolean), IQArray<Result>>, ICallable
    {
        public MixWord(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,Boolean,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "MixWord";
        String ICallable.FullName => "QTests.AES.MixWord";
        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> MaximovMixColumnMixWord
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Boolean)> QAESInPlaceMixWord
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,Boolean,Boolean), IQArray<Result>> Body => (__in__) =>
        {
            var (_word,in_place,costing) = __in__;
#line 98 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(32L);
#line hidden
            {
#line 100 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var word = Allocate.Apply(32L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 102 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 104 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_word[i], word[i]));
                    }

#line 107 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    if (in_place)
                    {
#line 109 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QAESInPlaceMixWord.Apply((word, costing));
#line 110 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 112 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            res.Modify(i, MicrosoftQuantumIntrinsicM.Apply(word[i]));
                        }
                    }
                    else
                    {
#line hidden
                        {
#line 117 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            var output = Allocate.Apply(32L);
#line hidden
                            Exception __arg3__ = null;
                            try
                            {
#line 119 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                MaximovMixColumnMixWord.Apply((word, output, costing));
#line 120 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                foreach (var i in new Range(0L, 31L))
#line hidden
                                {
#line 122 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                    res.Modify(i, MicrosoftQuantumIntrinsicM.Apply(output[i]));
#line 123 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                    QUtilitiesSet.Apply((Result.Zero, output[i]));
                                }
                            }
#line hidden
                            catch (Exception __arg4__)
                            {
                                __arg3__ = __arg4__;
                                throw __arg3__;
                            }
#line hidden
                            finally
                            {
                                if (__arg3__ != null)
                                {
                                    throw __arg3__;
                                }

#line hidden
                                Release.Apply(output);
                            }
                        }
                    }

#line 129 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 131 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, word[i]));
                    }
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
                    Release.Apply(word);
                }
            }

#line 134 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.MaximovMixColumnMixWord = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(MaximovMixColumn.MixWord));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QAESInPlaceMixWord = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Boolean)>>(typeof(QAES.InPlace.MixWord));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, IQArray<Result> _word, Boolean in_place, Boolean costing)
        {
            return __m__.Run<MixWord, (IQArray<Result>,Boolean,Boolean), IQArray<Result>>((_word, in_place, costing));
        }
    }

    public partial class MixColumn : Operation<(IQArray<Result>,Boolean,Boolean), IQArray<IQArray<Result>>>, ICallable
    {
        public MixColumn(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,Boolean,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "MixColumn";
        String ICallable.FullName => "QTests.AES.MixColumn";
        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Int64,Int64,Boolean)> MaximovMixColumnMixColumn
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)> QAESInPlaceMixColumn
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,Boolean,Boolean), IQArray<IQArray<Result>>> Body => (__in__) =>
        {
            var (_state,in_place,costing) = __in__;
#line 139 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 140 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 141 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 142 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 144 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var (state_1,state_2,state_3,state_4) = (Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 146 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    var state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(state_1, state_2, state_3, state_4);
#line 147 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 149 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 151 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_state[((j * 32L) + i)], state[j][i]));
                        }
                    }

#line 155 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    if (in_place)
                    {
#line 157 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QAESInPlaceMixColumn.Apply((state, costing));
#line 158 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 160 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[0L][i]));
                        }

#line 163 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 165 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[1L][i]));
                        }

#line 168 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 170 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[2L][i]));
                        }

#line 173 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 175 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[3L][i]));
                        }
                    }
                    else
                    {
#line hidden
                        {
#line 180 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            var (out_1,out_2,out_3,out_4) = (Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L));
#line hidden
                            Exception __arg3__ = null;
                            try
                            {
#line 182 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                MaximovMixColumnMixColumn.Apply((state, new QArray<IQArray<Qubit>>(out_1, out_2, out_3, out_4), 0L, 3L, costing));
#line 183 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                foreach (var i in new Range(0L, 31L))
#line hidden
                                {
#line 185 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                    res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_1[i]));
#line 186 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                    QUtilitiesSet.Apply((Result.Zero, out_1[i]));
                                }

#line 188 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                foreach (var i in new Range(0L, 31L))
#line hidden
                                {
#line 190 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                    res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_2[i]));
#line 191 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                    QUtilitiesSet.Apply((Result.Zero, out_2[i]));
                                }

#line 193 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                foreach (var i in new Range(0L, 31L))
#line hidden
                                {
#line 195 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                    res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_3[i]));
#line 196 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                    QUtilitiesSet.Apply((Result.Zero, out_3[i]));
                                }

#line 198 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                foreach (var i in new Range(0L, 31L))
#line hidden
                                {
#line 200 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                    res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_4[i]));
#line 201 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                                    QUtilitiesSet.Apply((Result.Zero, out_4[i]));
                                }
                            }
#line hidden
                            catch (Exception __arg4__)
                            {
                                __arg3__ = __arg4__;
                                throw __arg3__;
                            }
#line hidden
                            finally
                            {
                                if (__arg3__ != null)
                                {
                                    throw __arg3__;
                                }

#line hidden
                                Release.Apply(out_1);
#line hidden
                                Release.Apply(out_2);
#line hidden
                                Release.Apply(out_3);
#line hidden
                                Release.Apply(out_4);
                            }
                        }
                    }

#line 207 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 209 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 211 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, state[j][i]));
                        }
                    }
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
                    Release.Apply(state_1);
#line hidden
                    Release.Apply(state_2);
#line hidden
                    Release.Apply(state_3);
#line hidden
                    Release.Apply(state_4);
                }
            }

#line 215 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return new QArray<IQArray<Result>>(res_1?.Copy(), res_2?.Copy(), res_3?.Copy(), res_4?.Copy());
        }

        ;
        public override void Init()
        {
            this.MaximovMixColumnMixColumn = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Int64,Int64,Boolean)>>(typeof(MaximovMixColumn.MixColumn));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QAESInPlaceMixColumn = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,Boolean)>>(typeof(QAES.InPlace.MixColumn));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<IQArray<Result>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Result>>> Run(IOperationFactory __m__, IQArray<Result> _state, Boolean in_place, Boolean costing)
        {
            return __m__.Run<MixColumn, (IQArray<Result>,Boolean,Boolean), IQArray<IQArray<Result>>>((_state, in_place, costing));
        }
    }

    public partial class ByteSub : Operation<(IQArray<Result>,Boolean), IQArray<IQArray<Result>>>, ICallable
    {
        public ByteSub(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ByteSub";
        String ICallable.FullName => "QTests.AES.ByteSub";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean)> QAESByteSub
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,Boolean), IQArray<IQArray<Result>>> Body => (__in__) =>
        {
            var (_input_state,costing) = __in__;
#line 220 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 221 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 222 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 223 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 225 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var (input_state_1,input_state_2,input_state_3,input_state_4,output_state_1,output_state_2,output_state_3,output_state_4) = (Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 235 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    var input_state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(input_state_1, input_state_2, input_state_3, input_state_4);
#line 236 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    var output_state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(output_state_1, output_state_2, output_state_3, output_state_4);
#line 237 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 239 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 241 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_input_state[((j * 32L) + i)], input_state[j][i]));
                        }
                    }

#line 245 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QAESByteSub.Apply((input_state, output_state, costing));
#line 247 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 249 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(output_state[0L][i]));
                    }

#line 252 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 254 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(output_state[1L][i]));
                    }

#line 257 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 259 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(output_state[2L][i]));
                    }

#line 262 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 264 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(output_state[3L][i]));
                    }

#line 268 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 270 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 272 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, input_state[j][i]));
#line 273 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, output_state[j][i]));
                        }
                    }
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
                    Release.Apply(input_state_1);
#line hidden
                    Release.Apply(input_state_2);
#line hidden
                    Release.Apply(input_state_3);
#line hidden
                    Release.Apply(input_state_4);
#line hidden
                    Release.Apply(output_state_1);
#line hidden
                    Release.Apply(output_state_2);
#line hidden
                    Release.Apply(output_state_3);
#line hidden
                    Release.Apply(output_state_4);
                }
            }

#line 277 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return new QArray<IQArray<Result>>(res_1?.Copy(), res_2?.Copy(), res_3?.Copy(), res_4?.Copy());
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QAESByteSub = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,Boolean)>>(typeof(QAES.ByteSub));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<IQArray<Result>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Result>>> Run(IOperationFactory __m__, IQArray<Result> _input_state, Boolean costing)
        {
            return __m__.Run<ByteSub, (IQArray<Result>,Boolean), IQArray<IQArray<Result>>>((_input_state, costing));
        }
    }

    public partial class AddRoundKey : Operation<(IQArray<Result>,IQArray<Result>), IQArray<IQArray<Result>>>, ICallable
    {
        public AddRoundKey(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,IQArray<Result>)>, IApplyData
        {
            public In((IQArray<Result>,IQArray<Result>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "AddRoundKey";
        String ICallable.FullName => "QTests.AES.AddRoundKey";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)> QAESWidestAddRoundKey
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,IQArray<Result>), IQArray<IQArray<Result>>> Body => (__in__) =>
        {
            var (_state,_round_key) = __in__;
#line 282 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 283 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 284 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 285 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 287 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var (state_1,state_2,state_3,state_4,round_key) = (Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply((4L * 32L)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 297 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    var state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(state_1, state_2, state_3, state_4);
#line 298 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 300 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 302 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_state[((j * 32L) + i)], state[j][i]));
#line 303 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_round_key[((j * 32L) + i)], round_key[((32L * j) + i)]));
                        }
                    }

#line 307 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QAESWidestAddRoundKey.Apply((state, round_key));
#line 309 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 311 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[0L][i]));
                    }

#line 314 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 316 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[1L][i]));
                    }

#line 319 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 321 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[2L][i]));
                    }

#line 324 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 326 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[3L][i]));
                    }

#line 330 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 332 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 334 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, state[j][i]));
#line 335 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, round_key[((j * 32L) + i)]));
                        }
                    }
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
                    Release.Apply(state_1);
#line hidden
                    Release.Apply(state_2);
#line hidden
                    Release.Apply(state_3);
#line hidden
                    Release.Apply(state_4);
#line hidden
                    Release.Apply(round_key);
                }
            }

#line 339 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return new QArray<IQArray<Result>>(res_1?.Copy(), res_2?.Copy(), res_3?.Copy(), res_4?.Copy());
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QAESWidestAddRoundKey = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<Qubit>)>>(typeof(QAES.Widest.AddRoundKey));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,IQArray<Result>) data) => new In(data);
        public override IApplyData __dataOut(IQArray<IQArray<Result>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Result>>> Run(IOperationFactory __m__, IQArray<Result> _state, IQArray<Result> _round_key)
        {
            return __m__.Run<AddRoundKey, (IQArray<Result>,IQArray<Result>), IQArray<IQArray<Result>>>((_state, _round_key));
        }
    }

    public partial class KeyExpansion : Operation<(IQArray<Result>,Int64,Int64,Boolean), IQArray<Result>>, ICallable
    {
        public KeyExpansion(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,Int64,Int64,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,Int64,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "KeyExpansion";
        String ICallable.FullName => "QTests.AES.KeyExpansion";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Int64,Int64,Boolean)> QAESWidestKeyExpansion
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,Int64,Int64,Boolean), IQArray<Result>> Body => (__in__) =>
        {
            var (_key,Nr,Nk,costing) = __in__;
#line 344 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(((32L * 4L) * (Nr + 1L)));
#line hidden
            {
#line 346 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var key = Allocate.Apply(((32L * 4L) * (Nr + 1L)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 348 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, ((32L * Nk) - 1L)))
#line hidden
                    {
#line 350 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_key[i], key[i]));
                    }

#line 353 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QAESWidestKeyExpansion.Apply((key, Nr, Nk, costing));
#line 355 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, (((32L * 4L) * (Nr + 1L)) - 1L)))
#line hidden
                    {
#line 357 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res.Modify(i, MicrosoftQuantumIntrinsicM.Apply(key[i]));
                    }

#line 361 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, (((32L * 4L) * (Nr + 1L)) - 1L)))
#line hidden
                    {
#line 363 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, key[i]));
                    }
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
                    Release.Apply(key);
                }
            }

#line 366 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QAESWidestKeyExpansion = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Int64,Int64,Boolean)>>(typeof(QAES.Widest.KeyExpansion));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,Int64,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, IQArray<Result> _key, Int64 Nr, Int64 Nk, Boolean costing)
        {
            return __m__.Run<KeyExpansion, (IQArray<Result>,Int64,Int64,Boolean), IQArray<Result>>((_key, Nr, Nk, costing));
        }
    }

    public partial class InPlacePartialKeyExpansion : Operation<(IQArray<Result>,Int64,Int64,Int64,Int64,Int64,Boolean), IQArray<Result>>, ICallable
    {
        public InPlacePartialKeyExpansion(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,Int64,Int64,Int64,Int64,Int64,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,Int64,Int64,Int64,Int64,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "InPlacePartialKeyExpansion";
        String ICallable.FullName => "QTests.AES.InPlacePartialKeyExpansion";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean)> QAESInPlaceKeyExpansion
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,Int64,Int64,Int64,Int64,Int64,Boolean), IQArray<Result>> Body => (__in__) =>
        {
            var (_key,Nr,Nk,kexp_round,low,high,costing) = __in__;
#line 371 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(((32L * 4L) * (Nr + 1L)));
#line hidden
            {
#line 373 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var key = Allocate.Apply(((32L * 4L) * (Nr + 1L)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 375 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, ((32L * Nk) - 1L)))
#line hidden
                    {
#line 377 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_key[i], key[i]));
                    }

#line 380 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QAESInPlaceKeyExpansion.Apply((key, kexp_round, Nk, low, high, costing));
#line 382 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, (((32L * 4L) * (Nr + 1L)) - 1L)))
#line hidden
                    {
#line 384 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res.Modify(i, MicrosoftQuantumIntrinsicM.Apply(key[i]));
                    }

#line 388 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, (((32L * 4L) * (Nr + 1L)) - 1L)))
#line hidden
                    {
#line 390 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, key[i]));
                    }
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
                    Release.Apply(key);
                }
            }

#line 393 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QAESInPlaceKeyExpansion = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean)>>(typeof(QAES.InPlace.KeyExpansion));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,Int64,Int64,Int64,Int64,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, IQArray<Result> _key, Int64 Nr, Int64 Nk, Int64 kexp_round, Int64 low, Int64 high, Boolean costing)
        {
            return __m__.Run<InPlacePartialKeyExpansion, (IQArray<Result>,Int64,Int64,Int64,Int64,Int64,Boolean), IQArray<Result>>((_key, Nr, Nk, kexp_round, low, high, costing));
        }
    }

    public partial class InPlaceKeyExpansion : Operation<(IQArray<Result>,Int64,Int64,Boolean), IQArray<Result>>, ICallable
    {
        public InPlaceKeyExpansion(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,Int64,Int64,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,Int64,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "InPlaceKeyExpansion";
        String ICallable.FullName => "QTests.AES.InPlaceKeyExpansion";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean)> QAESInPlaceKeyExpansion
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)> QUtilitiesCNOTnBits
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,Int64,Int64,Boolean), IQArray<Result>> Body => (__in__) =>
        {
            var (_key,Nr,Nk,costing) = __in__;
#line 398 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(((32L * 4L) * (Nr + 1L)));
#line hidden
            {
#line 400 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var (key,temp) = (Allocate.Apply(((32L * 4L) * (Nr + 1L))), Allocate.Apply((32L * Nk)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 402 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, ((32L * Nk) - 1L)))
#line hidden
                    {
#line 404 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_key[i], key[i]));
#line 405 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_key[i], temp[i]));
                    }

#line 408 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    var key_rounds = (((Nr + 1L) * 4L) / Nk);
#line 409 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var round in new Range(1L, key_rounds))
#line hidden
                    {
#line 411 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QAESInPlaceKeyExpansion.Apply((temp, round, Nk, 0L, (Nk / 2L), costing));
#line 412 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QAESInPlaceKeyExpansion.Apply((temp, round, Nk, ((Nk / 2L) + 1L), (Nk - 1L), costing));
#line 413 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        if ((round < key_rounds))
                        {
#line 415 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesCNOTnBits.Apply((temp, key?.Slice(new Range(((round * Nk) * 32L), ((((round + 1L) * Nk) * 32L) - 1L))), (Nk * 32L)));
                        }
                        else
                        {
#line 419 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesCNOTnBits.Apply((temp, key?.Slice(new Range(((round * Nk) * 32L), ((((round * Nk) * 32L) + (32L * ((4L * (Nr + 1L)) - (key_rounds * Nk)))) - 1L))), (32L * ((4L * (Nr + 1L)) - (key_rounds * Nk)))));
                        }
                    }

#line 423 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, (((32L * 4L) * (Nr + 1L)) - 1L)))
#line hidden
                    {
#line 425 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res.Modify(i, MicrosoftQuantumIntrinsicM.Apply(key[i]));
                    }

#line 429 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, (((32L * 4L) * (Nr + 1L)) - 1L)))
#line hidden
                    {
#line 431 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, key[i]));
                    }

#line 433 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, ((32L * Nk) - 1L)))
#line hidden
                    {
#line 435 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, temp[i]));
                    }
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
                    Release.Apply(key);
#line hidden
                    Release.Apply(temp);
                }
            }

#line 438 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QAESInPlaceKeyExpansion = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Int64,Int64,Int64,Int64,Boolean)>>(typeof(QAES.InPlace.KeyExpansion));
            this.QUtilitiesCNOTnBits = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)>>(typeof(QUtilities.CNOTnBits));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,Int64,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, IQArray<Result> _key, Int64 Nr, Int64 Nk, Boolean costing)
        {
            return __m__.Run<InPlaceKeyExpansion, (IQArray<Result>,Int64,Int64,Boolean), IQArray<Result>>((_key, Nr, Nk, costing));
        }
    }

    public partial class Round : Operation<(IQArray<Result>,IQArray<Result>,Int64,Boolean,Int64,Boolean,Boolean), IQArray<IQArray<Result>>>, ICallable
    {
        public Round(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,IQArray<Result>,Int64,Boolean,Int64,Boolean,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,IQArray<Result>,Int64,Boolean,Int64,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Round";
        String ICallable.FullName => "QTests.AES.Round";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean)> QAESSmartWideRound
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean)> QAESWidestRound
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,IQArray<Result>,Int64,Boolean,Int64,Boolean,Boolean), IQArray<IQArray<Result>>> Body => (__in__) =>
        {
            var (_state,_round_key,round,smart_wide,Nk,in_place_mixcolumn,costing) = __in__;
#line 443 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 444 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 445 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 446 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 448 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var (in_state_1,in_state_2,in_state_3,in_state_4,out_state_1,out_state_2,out_state_3,out_state_4,out_state_5,out_state_6,out_state_7,out_state_8,round_key) = (Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply((Nk * 32L)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 462 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    var in_state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(in_state_1, in_state_2, in_state_3, in_state_4);
#line 463 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    var out_state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(out_state_1, out_state_2, out_state_3, out_state_4, out_state_5, out_state_6, out_state_7, out_state_8);
#line 464 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 466 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 468 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_state[((j * 32L) + i)], in_state[j][i]));
#line 469 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_round_key[((j * 32L) + i)], round_key[((32L * j) + i)]));
                        }
                    }

#line 473 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    if (smart_wide)
                    {
#line 475 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QAESSmartWideRound.Apply((in_state, out_state, round_key, round, Nk, in_place_mixcolumn, costing));
                    }
                    else
                    {
#line 482 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QAESWidestRound.Apply((in_state, out_state?.Slice(new Range(4L, 7L)), round_key, 0L, costing));
                    }

#line 485 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 487 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[4L][i]));
                    }

#line 490 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 492 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[5L][i]));
                    }

#line 495 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 497 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[6L][i]));
                    }

#line 500 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 502 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[7L][i]));
                    }

#line 506 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 508 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 510 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, in_state[j][i]));
#line 511 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, out_state[j][i]));
#line 512 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, out_state[(j + 4L)][i]));
#line 513 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, round_key[((j * 32L) + i)]));
                        }
                    }
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
                    Release.Apply(in_state_1);
#line hidden
                    Release.Apply(in_state_2);
#line hidden
                    Release.Apply(in_state_3);
#line hidden
                    Release.Apply(in_state_4);
#line hidden
                    Release.Apply(out_state_1);
#line hidden
                    Release.Apply(out_state_2);
#line hidden
                    Release.Apply(out_state_3);
#line hidden
                    Release.Apply(out_state_4);
#line hidden
                    Release.Apply(out_state_5);
#line hidden
                    Release.Apply(out_state_6);
#line hidden
                    Release.Apply(out_state_7);
#line hidden
                    Release.Apply(out_state_8);
#line hidden
                    Release.Apply(round_key);
                }
            }

#line 517 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return new QArray<IQArray<Result>>(res_1?.Copy(), res_2?.Copy(), res_3?.Copy(), res_4?.Copy());
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QAESSmartWideRound = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean)>>(typeof(QAES.SmartWide.Round));
            this.QAESWidestRound = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean)>>(typeof(QAES.Widest.Round));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,IQArray<Result>,Int64,Boolean,Int64,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<IQArray<Result>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Result>>> Run(IOperationFactory __m__, IQArray<Result> _state, IQArray<Result> _round_key, Int64 round, Boolean smart_wide, Int64 Nk, Boolean in_place_mixcolumn, Boolean costing)
        {
            return __m__.Run<Round, (IQArray<Result>,IQArray<Result>,Int64,Boolean,Int64,Boolean,Boolean), IQArray<IQArray<Result>>>((_state, _round_key, round, smart_wide, Nk, in_place_mixcolumn, costing));
        }
    }

    public partial class FinalRound : Operation<(IQArray<Result>,IQArray<Result>,Boolean,Int64,Boolean), IQArray<IQArray<Result>>>, ICallable
    {
        public FinalRound(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,IQArray<Result>,Boolean,Int64,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,IQArray<Result>,Boolean,Int64,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "FinalRound";
        String ICallable.FullName => "QTests.AES.FinalRound";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean)> QAESSmartWideFinalRound
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean)> QAESWidestFinalRound
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,IQArray<Result>,Boolean,Int64,Boolean), IQArray<IQArray<Result>>> Body => (__in__) =>
        {
            var (_state,_round_key,smart_wide,Nr,costing) = __in__;
#line 522 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 523 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 524 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 525 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 527 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var (in_state_1,in_state_2,in_state_3,in_state_4,out_state_1,out_state_2,out_state_3,out_state_4,round_key) = (Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(((4L * 32L) * (Nr + 1L))));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 539 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    var in_state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(in_state_1, in_state_2, in_state_3, in_state_4);
#line 540 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    var out_state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(out_state_1, out_state_2, out_state_3, out_state_4);
#line 541 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 543 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 545 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_state[((j * 32L) + i)], in_state[j][i]));
#line 546 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_round_key[((j * 32L) + i)], round_key[((((4L * 32L) * Nr) + (32L * j)) + i)]));
                        }
                    }

#line 550 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    if (smart_wide)
                    {
#line 552 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QAESSmartWideFinalRound.Apply((in_state, out_state, round_key, Nr, (Nr - 6L), costing));
                    }
                    else
                    {
#line 556 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QAESWidestFinalRound.Apply((in_state, out_state, round_key, Nr, costing));
                    }

#line 559 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 561 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[0L][i]));
                    }

#line 564 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 566 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[1L][i]));
                    }

#line 569 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 571 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[2L][i]));
                    }

#line 574 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 576 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[3L][i]));
                    }

#line 580 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 582 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 584 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, in_state[j][i]));
#line 585 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, out_state[j][i]));
#line 586 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, round_key[((((4L * 32L) * Nr) + (j * 32L)) + i)]));
                        }
                    }
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
                    Release.Apply(in_state_1);
#line hidden
                    Release.Apply(in_state_2);
#line hidden
                    Release.Apply(in_state_3);
#line hidden
                    Release.Apply(in_state_4);
#line hidden
                    Release.Apply(out_state_1);
#line hidden
                    Release.Apply(out_state_2);
#line hidden
                    Release.Apply(out_state_3);
#line hidden
                    Release.Apply(out_state_4);
#line hidden
                    Release.Apply(round_key);
                }
            }

#line 590 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return new QArray<IQArray<Result>>(res_1?.Copy(), res_2?.Copy(), res_3?.Copy(), res_4?.Copy());
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QAESSmartWideFinalRound = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Int64,Boolean)>>(typeof(QAES.SmartWide.FinalRound));
            this.QAESWidestFinalRound = this.Factory.Get<IAdjointable<(IQArray<IQArray<Qubit>>,IQArray<IQArray<Qubit>>,IQArray<Qubit>,Int64,Boolean)>>(typeof(QAES.Widest.FinalRound));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,IQArray<Result>,Boolean,Int64,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<IQArray<Result>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Result>>> Run(IOperationFactory __m__, IQArray<Result> _state, IQArray<Result> _round_key, Boolean smart_wide, Int64 Nr, Boolean costing)
        {
            return __m__.Run<FinalRound, (IQArray<Result>,IQArray<Result>,Boolean,Int64,Boolean), IQArray<IQArray<Result>>>((_state, _round_key, smart_wide, Nr, costing));
        }
    }

    public partial class WideRijndael : Operation<(IQArray<Result>,IQArray<Result>,Int64,Int64,Boolean,Boolean), IQArray<IQArray<Result>>>, ICallable
    {
        public WideRijndael(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,IQArray<Result>,Int64,Int64,Boolean,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,IQArray<Result>,Int64,Int64,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "WideRijndael";
        String ICallable.FullName => "QTests.AES.WideRijndael";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean)> QAESWidestRijndael
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,IQArray<Result>,Int64,Int64,Boolean,Boolean), IQArray<IQArray<Result>>> Body => (__in__) =>
        {
            var (_message,_key,Nr,Nk,in_place_mixcolumn,costing) = __in__;
#line 596 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 597 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 598 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 599 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 601 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var (state,expanded_key,ciphertext) = (Allocate.Apply(((4L * 32L) * (Nr + 1L))), Allocate.Apply(((4L * 32L) * (Nr + 1L))), Allocate.Apply((4L * 32L)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 603 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 605 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 607 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_message[((j * 32L) + i)], state[((j * 32L) + i)]));
                        }
                    }

#line 610 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, (Nk - 1L)))
#line hidden
                    {
#line 612 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 614 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_key[((j * 32L) + i)], expanded_key[((j * 32L) + i)]));
                        }
                    }

#line 619 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QAESWidestRijndael.Apply((expanded_key, state, ciphertext, Nr, Nk, costing));
#line 621 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 623 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((0L * 32L) + i)]));
                    }

#line 626 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 628 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((1L * 32L) + i)]));
                    }

#line 631 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 633 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((2L * 32L) + i)]));
                    }

#line 636 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 638 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((3L * 32L) + i)]));
                    }

#line 642 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 644 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 646 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, state[((j * 32L) + i)]));
#line 647 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, ciphertext[((j * 32L) + i)]));
                        }
                    }

#line 650 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, (Nk - 1L)))
#line hidden
                    {
#line 652 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 654 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, expanded_key[((j * 32L) + i)]));
                        }
                    }
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
                    Release.Apply(state);
#line hidden
                    Release.Apply(expanded_key);
#line hidden
                    Release.Apply(ciphertext);
                }
            }

#line 658 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return new QArray<IQArray<Result>>(res_1?.Copy(), res_2?.Copy(), res_3?.Copy(), res_4?.Copy());
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QAESWidestRijndael = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean)>>(typeof(QAES.Widest.Rijndael));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,IQArray<Result>,Int64,Int64,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<IQArray<Result>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Result>>> Run(IOperationFactory __m__, IQArray<Result> _message, IQArray<Result> _key, Int64 Nr, Int64 Nk, Boolean in_place_mixcolumn, Boolean costing)
        {
            return __m__.Run<WideRijndael, (IQArray<Result>,IQArray<Result>,Int64,Int64,Boolean,Boolean), IQArray<IQArray<Result>>>((_message, _key, Nr, Nk, in_place_mixcolumn, costing));
        }
    }

    public partial class SmartWideRijndael : Operation<(IQArray<Result>,IQArray<Result>,Int64,Int64,Boolean,Boolean), IQArray<IQArray<Result>>>, ICallable
    {
        public SmartWideRijndael(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,IQArray<Result>,Int64,Int64,Boolean,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,IQArray<Result>,Int64,Int64,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "SmartWideRijndael";
        String ICallable.FullName => "QTests.AES.SmartWideRijndael";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean)> QAESSmartWideRijndael
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,IQArray<Result>,Int64,Int64,Boolean,Boolean), IQArray<IQArray<Result>>> Body => (__in__) =>
        {
            var (_message,_key,Nr,Nk,in_place_mixcolumn,costing) = __in__;
#line 664 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 665 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 666 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 667 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 669 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                var (state,key,ciphertext) = (Allocate.Apply(((4L * 32L) * (in_place_mixcolumn ? (Nr + 1L) : (2L * Nr)))), Allocate.Apply((Nk * 32L)), Allocate.Apply((4L * 32L)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 671 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 673 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 675 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_message[((j * 32L) + i)], state[((j * 32L) + i)]));
                        }
                    }

#line 678 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, (Nk - 1L)))
#line hidden
                    {
#line 680 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 682 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_key[((j * 32L) + i)], key[((j * 32L) + i)]));
                        }
                    }

#line 686 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    QAESSmartWideRijndael.Apply((key, state, ciphertext, Nr, Nk, in_place_mixcolumn, costing));
#line 688 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 690 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((0L * 32L) + i)]));
                    }

#line 693 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 695 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((1L * 32L) + i)]));
                    }

#line 698 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 700 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((2L * 32L) + i)]));
                    }

#line 703 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 705 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((3L * 32L) + i)]));
                    }

#line 709 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 711 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 713 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, ciphertext[((j * 32L) + i)]));
                        }
                    }

#line 716 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, (((4L * 32L) * (in_place_mixcolumn ? (Nr + 1L) : (2L * Nr))) - 1L)))
#line hidden
                    {
#line 718 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, state[j]));
                    }

#line 720 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, (Nk - 1L)))
#line hidden
                    {
#line 722 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 724 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, key[((j * 32L) + i)]));
                        }
                    }
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
                    Release.Apply(state);
#line hidden
                    Release.Apply(key);
#line hidden
                    Release.Apply(ciphertext);
                }
            }

#line 728 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QTests.qs"
            return new QArray<IQArray<Result>>(res_1?.Copy(), res_2?.Copy(), res_3?.Copy(), res_4?.Copy());
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QAESSmartWideRijndael = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Int64,Int64,Boolean,Boolean)>>(typeof(QAES.SmartWide.Rijndael));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,IQArray<Result>,Int64,Int64,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<IQArray<Result>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Result>>> Run(IOperationFactory __m__, IQArray<Result> _message, IQArray<Result> _key, Int64 Nr, Int64 Nk, Boolean in_place_mixcolumn, Boolean costing)
        {
            return __m__.Run<SmartWideRijndael, (IQArray<Result>,IQArray<Result>,Int64,Int64,Boolean,Boolean), IQArray<IQArray<Result>>>((_message, _key, Nr, Nk, in_place_mixcolumn, costing));
        }
    }
}