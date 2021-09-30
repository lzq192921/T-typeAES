#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.Utilities\",\"Name\":\"AND\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":1007,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":26},\"Item2\":{\"Line\":1,\"Column\":27}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.Utilities\",\"Name\":\"AND\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":1007,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.Utilities\",\"Name\":\"ANDadj\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":1027,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":19}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":30}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Result\"}]]},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.Utilities\",\"Name\":\"ANDadj\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":1027,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"SBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":232,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":18}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"tower_field\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"LPS19\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":69}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"SBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":232,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"ShiftRow\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":273,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":20},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":45}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"ShiftRow\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":273,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"MixWord\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":325,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_word\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":52},\"Item2\":{\"Line\":1,\"Column\":59}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"MixWord\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":325,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"MixColumn\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":366,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":47}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":62}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"MixColumn\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":366,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"ByteSub\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":447,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_input_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":50}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"ByteSub\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":447,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"AddRoundKey\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":509,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_round_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":51}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"AddRoundKey\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":509,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"KeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":571,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":65}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"KeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":571,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"InPlacePartialKeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":598,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":38},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":65}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"kexp_round\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":72},\"Item2\":{\"Line\":1,\"Column\":82}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"low\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":89},\"Item2\":{\"Line\":1,\"Column\":92}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"high\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":99},\"Item2\":{\"Line\":1,\"Column\":103}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":110},\"Item2\":{\"Line\":1,\"Column\":117}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"InPlacePartialKeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":598,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"InPlaceKeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":625,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":49}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":56},\"Item2\":{\"Line\":1,\"Column\":58}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"InPlaceKeyExpansion\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":625,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"Round\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":670,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_round_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"round\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":62}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"smart_wide\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":79}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":87},\"Item2\":{\"Line\":1,\"Column\":89}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place_mixcolumn\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":96},\"Item2\":{\"Line\":1,\"Column\":114}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":122},\"Item2\":{\"Line\":1,\"Column\":129}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Int\"},{\"Case\":\"Bool\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"Round\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":670,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"FinalRound\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":749,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_state\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_round_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":50}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"smart_wide\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":72}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":80},\"Item2\":{\"Line\":1,\"Column\":82}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":89},\"Item2\":{\"Line\":1,\"Column\":96}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"FinalRound\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":749,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"WideRijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":823,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_message\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":32}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":62}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":69},\"Item2\":{\"Line\":1,\"Column\":71}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place_mixcolumn\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":96}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":104},\"Item2\":{\"Line\":1,\"Column\":111}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"WideRijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":823,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":23}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"SmartWideRijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":891,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_message\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":49},\"Item2\":{\"Line\":1,\"Column\":53}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":65},\"Item2\":{\"Line\":1,\"Column\":67}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":74},\"Item2\":{\"Line\":1,\"Column\":76}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place_mixcolumn\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":83},\"Item2\":{\"Line\":1,\"Column\":101}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":109},\"Item2\":{\"Line\":1,\"Column\":116}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"SmartWideRijndael\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":891,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.AES\",\"Name\":\"SmartWideGroverOracle\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":960,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_key\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_plaintexts\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":61}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target_ciphertext\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":73},\"Item2\":{\"Line\":1,\"Column\":90}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"pairs\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":100},\"Item2\":{\"Line\":1,\"Column\":105}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nr\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":112},\"Item2\":{\"Line\":1,\"Column\":114}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Nk\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":121},\"Item2\":{\"Line\":1,\"Column\":123}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place_mixcolumn\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":130},\"Item2\":{\"Line\":1,\"Column\":148}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":156},\"Item2\":{\"Line\":1,\"Column\":163}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.AES\",\"Name\":\"SmartWideGroverOracle\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":960,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.GF256\",\"Name\":\"Inverse\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.GF256\",\"Name\":\"Inverse\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":18}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.GF256\",\"Name\":\"Mul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":17}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"unrolled\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":60},\"Item2\":{\"Line\":1,\"Column\":67}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.GF256\",\"Name\":\"Mul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":37,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.GF256\",\"Name\":\"Square\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":73,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.GF256\",\"Name\":\"Square\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":73,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.GF256\",\"Name\":\"Fourth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":114,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":32},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.GF256\",\"Name\":\"Fourth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":114,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.GF256\",\"Name\":\"Sixteenth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":155,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.GF256\",\"Name\":\"Sixteenth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":155,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QTests.GF256\",\"Name\":\"SixtyFourth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":182,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"_a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_place\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":60}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},{\"Case\":\"Bool\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QTests.GF256\",\"Name\":\"SixtyFourth\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/grover-blocks-masterdepth%20-%20%E5%89%AF%E6%9C%AC%20(2)%20-%20%E5%89%AF%E6%9C%AC%20-%20%E5%89%AF%E6%9C%AC/aes/QTests.qs\",\"Position\":{\"Item1\":182,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
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
#line 1010 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res = Result.Zero;
#line hidden
            {
#line 1011 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (a,b,c) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 1013 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((x, a));
#line 1014 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((y, b));
#line 1016 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QUtilitiesAND.Apply((a, b, c));
#line 1018 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    res = MicrosoftQuantumIntrinsicM.Apply(c);
#line 1021 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((Result.Zero, a));
#line 1022 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((Result.Zero, b));
#line 1023 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 1025 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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
#line 1030 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res = Result.Zero;
#line hidden
            {
#line 1031 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (a,b,c) = (Allocate.Apply(), Allocate.Apply(), Allocate.Apply());
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 1033 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((x, a));
#line 1034 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((y, b));
#line 1035 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((MicrosoftQuantumConvertBoolAsResult.Apply((MicrosoftQuantumConvertResultAsBool.Apply(x) && MicrosoftQuantumConvertResultAsBool.Apply(y))), c));
#line 1037 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QUtilitiesAND.Adjoint.Apply((a, b, c));
#line 1039 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    res = MicrosoftQuantumIntrinsicM.Apply(c);
#line 1042 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((Result.Zero, a));
#line 1043 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((Result.Zero, b));
#line 1044 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 1046 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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
#line 235 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(8L);
#line hidden
            {
#line 236 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (a,b) = (Allocate.Apply(8L), Allocate.Apply(8L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 238 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 240 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_a[(i - 1L)], a[(i - 1L)]));
                    }

#line 251 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    TtypeSBox.Apply((a, b, costing));
#line 259 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 261 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res.Modify((i - 1L), MicrosoftQuantumIntrinsicM.Apply(b[(i - 1L)]));
                    }

#line 265 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 267 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, a[(i - 1L)]));
#line 268 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 271 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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
#line 276 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 277 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 278 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 279 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 281 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (state_1,state_2,state_3,state_4) = (Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 283 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    var state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(state_1, state_2, state_3, state_4);
#line 284 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 286 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 288 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_state[((j * 32L) + i)], state[j][i]));
                        }
                    }

#line 292 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QAESInPlaceShiftRow.Apply((state, costing));
#line 294 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 296 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[0L][i]));
                    }

#line 299 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 301 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[1L][i]));
                    }

#line 304 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 306 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[2L][i]));
                    }

#line 309 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 311 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[3L][i]));
                    }

#line 315 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 317 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 319 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 323 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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
#line 328 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(32L);
#line hidden
            {
#line 330 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var word = Allocate.Apply(32L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 332 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 334 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_word[i], word[i]));
                    }

#line 337 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    if (in_place)
                    {
#line 339 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QAESInPlaceMixWord.Apply((word, costing));
#line 340 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 342 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            res.Modify(i, MicrosoftQuantumIntrinsicM.Apply(word[i]));
                        }
                    }
                    else
                    {
#line hidden
                        {
#line 347 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            var output = Allocate.Apply(32L);
#line hidden
                            Exception __arg3__ = null;
                            try
                            {
#line 349 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                MaximovMixColumnMixWord.Apply((word, output, costing));
#line 350 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                foreach (var i in new Range(0L, 31L))
#line hidden
                                {
#line 352 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                    res.Modify(i, MicrosoftQuantumIntrinsicM.Apply(output[i]));
#line 353 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 359 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 361 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 364 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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
#line 369 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 370 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 371 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 372 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 374 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (state_1,state_2,state_3,state_4) = (Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 376 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    var state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(state_1, state_2, state_3, state_4);
#line 377 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 379 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 381 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_state[((j * 32L) + i)], state[j][i]));
                        }
                    }

#line 385 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    if (in_place)
                    {
#line 387 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QAESInPlaceMixColumn.Apply((state, costing));
#line 388 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 390 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[0L][i]));
                        }

#line 393 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 395 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[1L][i]));
                        }

#line 398 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 400 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[2L][i]));
                        }

#line 403 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 405 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[3L][i]));
                        }
                    }
                    else
                    {
#line hidden
                        {
#line 410 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            var (out_1,out_2,out_3,out_4) = (Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L));
#line hidden
                            Exception __arg3__ = null;
                            try
                            {
#line 412 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                MaximovMixColumnMixColumn.Apply((state, new QArray<IQArray<Qubit>>(out_1, out_2, out_3, out_4), 0L, 3L, costing));
#line 413 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                foreach (var i in new Range(0L, 31L))
#line hidden
                                {
#line 415 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                    res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_1[i]));
#line 416 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                    QUtilitiesSet.Apply((Result.Zero, out_1[i]));
                                }

#line 418 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                foreach (var i in new Range(0L, 31L))
#line hidden
                                {
#line 420 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                    res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_2[i]));
#line 421 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                    QUtilitiesSet.Apply((Result.Zero, out_2[i]));
                                }

#line 423 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                foreach (var i in new Range(0L, 31L))
#line hidden
                                {
#line 425 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                    res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_3[i]));
#line 426 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                    QUtilitiesSet.Apply((Result.Zero, out_3[i]));
                                }

#line 428 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                foreach (var i in new Range(0L, 31L))
#line hidden
                                {
#line 430 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                                    res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_4[i]));
#line 431 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 437 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 439 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 441 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 445 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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
#line 450 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 451 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 452 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 453 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 455 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (input_state_1,input_state_2,input_state_3,input_state_4,output_state_1,output_state_2,output_state_3,output_state_4) = (Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 465 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    var input_state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(input_state_1, input_state_2, input_state_3, input_state_4);
#line 466 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    var output_state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(output_state_1, output_state_2, output_state_3, output_state_4);
#line 467 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 469 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 471 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_input_state[((j * 32L) + i)], input_state[j][i]));
                        }
                    }

#line 475 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QAESByteSub.Apply((input_state, output_state, costing));
#line 477 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 479 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(output_state[0L][i]));
                    }

#line 482 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 484 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(output_state[1L][i]));
                    }

#line 487 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 489 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(output_state[2L][i]));
                    }

#line 492 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 494 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(output_state[3L][i]));
                    }

#line 498 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 500 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 502 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, input_state[j][i]));
#line 503 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 507 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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
#line 512 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 513 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 514 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 515 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 517 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (state_1,state_2,state_3,state_4,round_key) = (Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply((4L * 32L)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 527 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    var state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(state_1, state_2, state_3, state_4);
#line 528 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 530 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 532 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_state[((j * 32L) + i)], state[j][i]));
#line 533 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_round_key[((j * 32L) + i)], round_key[((32L * j) + i)]));
                        }
                    }

#line 537 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QAESWidestAddRoundKey.Apply((state, round_key));
#line 539 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 541 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[0L][i]));
                    }

#line 544 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 546 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[1L][i]));
                    }

#line 549 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 551 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[2L][i]));
                    }

#line 554 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 556 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(state[3L][i]));
                    }

#line 560 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 562 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 564 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, state[j][i]));
#line 565 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 569 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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
#line 574 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(((32L * 4L) * (Nr + 1L)));
#line hidden
            {
#line 576 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var key = Allocate.Apply(((32L * 4L) * (Nr + 1L)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 578 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, ((32L * Nk) - 1L)))
#line hidden
                    {
#line 580 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_key[i], key[i]));
                    }

#line 583 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QAESWidestKeyExpansion.Apply((key, Nr, Nk, costing));
#line 585 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, (((32L * 4L) * (Nr + 1L)) - 1L)))
#line hidden
                    {
#line 587 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res.Modify(i, MicrosoftQuantumIntrinsicM.Apply(key[i]));
                    }

#line 591 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, (((32L * 4L) * (Nr + 1L)) - 1L)))
#line hidden
                    {
#line 593 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 596 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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
#line 601 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(((32L * 4L) * (Nr + 1L)));
#line hidden
            {
#line 603 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var key = Allocate.Apply(((32L * 4L) * (Nr + 1L)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 605 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, ((32L * Nk) - 1L)))
#line hidden
                    {
#line 607 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_key[i], key[i]));
                    }

#line 610 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QAESInPlaceKeyExpansion.Apply((key, kexp_round, Nk, low, high, costing));
#line 612 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, (((32L * 4L) * (Nr + 1L)) - 1L)))
#line hidden
                    {
#line 614 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res.Modify(i, MicrosoftQuantumIntrinsicM.Apply(key[i]));
                    }

#line 618 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, (((32L * 4L) * (Nr + 1L)) - 1L)))
#line hidden
                    {
#line 620 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 623 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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
#line 628 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(((32L * 4L) * (Nr + 1L)));
#line hidden
            {
#line 630 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (key,temp) = (Allocate.Apply(((32L * 4L) * (Nr + 1L))), Allocate.Apply((32L * Nk)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 632 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, ((32L * Nk) - 1L)))
#line hidden
                    {
#line 634 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_key[i], key[i]));
#line 635 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_key[i], temp[i]));
                    }

#line 638 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    var key_rounds = (((Nr + 1L) * 4L) / Nk);
#line 639 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var round in new Range(1L, key_rounds))
#line hidden
                    {
#line 641 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QAESInPlaceKeyExpansion.Apply((temp, round, Nk, 0L, (Nk / 2L), costing));
#line 642 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QAESInPlaceKeyExpansion.Apply((temp, round, Nk, ((Nk / 2L) + 1L), (Nk - 1L), costing));
#line 643 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        if ((round < key_rounds))
                        {
#line 645 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesCNOTnBits.Apply((temp, key?.Slice(new Range(((round * Nk) * 32L), ((((round + 1L) * Nk) * 32L) - 1L))), (Nk * 32L)));
                        }
                        else
                        {
#line 649 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesCNOTnBits.Apply((temp, key?.Slice(new Range(((round * Nk) * 32L), ((((round * Nk) * 32L) + (32L * ((4L * (Nr + 1L)) - (key_rounds * Nk)))) - 1L))), (32L * ((4L * (Nr + 1L)) - (key_rounds * Nk)))));
                        }
                    }

#line 653 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, (((32L * 4L) * (Nr + 1L)) - 1L)))
#line hidden
                    {
#line 655 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res.Modify(i, MicrosoftQuantumIntrinsicM.Apply(key[i]));
                    }

#line 659 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, (((32L * 4L) * (Nr + 1L)) - 1L)))
#line hidden
                    {
#line 661 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, key[i]));
                    }

#line 663 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, ((32L * Nk) - 1L)))
#line hidden
                    {
#line 665 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 668 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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
#line 673 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 674 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 675 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 676 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 678 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (in_state_1,in_state_2,in_state_3,in_state_4,out_state_1,out_state_2,out_state_3,out_state_4,out_state_5,out_state_6,out_state_7,out_state_8,round_key) = (Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply((Nk * 32L)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 692 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    var in_state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(in_state_1, in_state_2, in_state_3, in_state_4);
#line 693 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    var out_state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(out_state_1, out_state_2, out_state_3, out_state_4, out_state_5, out_state_6, out_state_7, out_state_8);
#line 694 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 696 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 698 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_state[((j * 32L) + i)], in_state[j][i]));
#line 699 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_round_key[((j * 32L) + i)], round_key[((32L * j) + i)]));
                        }
                    }

#line 703 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    if (smart_wide)
                    {
#line 705 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QAESSmartWideRound.Apply((in_state, out_state, round_key, round, Nk, in_place_mixcolumn, costing));
                    }
                    else
                    {
#line 712 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QAESWidestRound.Apply((in_state, out_state?.Slice(new Range(4L, 7L)), round_key, 0L, costing));
                    }

#line 715 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 717 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[4L][i]));
                    }

#line 720 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 722 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[5L][i]));
                    }

#line 725 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 727 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[6L][i]));
                    }

#line 730 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 732 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[7L][i]));
                    }

#line 736 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 738 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 740 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, in_state[j][i]));
#line 741 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, out_state[j][i]));
#line 742 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, out_state[(j + 4L)][i]));
#line 743 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 747 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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
#line 752 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 753 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 754 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 755 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 757 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (in_state_1,in_state_2,in_state_3,in_state_4,out_state_1,out_state_2,out_state_3,out_state_4,round_key) = (Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(32L), Allocate.Apply(((4L * 32L) * (Nr + 1L))));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 769 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    var in_state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(in_state_1, in_state_2, in_state_3, in_state_4);
#line 770 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    var out_state = (IQArray<IQArray<Qubit>>)new QArray<IQArray<Qubit>>(out_state_1, out_state_2, out_state_3, out_state_4);
#line 771 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 773 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 775 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_state[((j * 32L) + i)], in_state[j][i]));
#line 776 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_round_key[((j * 32L) + i)], round_key[((((4L * 32L) * Nr) + (32L * j)) + i)]));
                        }
                    }

#line 780 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    if (smart_wide)
                    {
#line 782 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QAESSmartWideFinalRound.Apply((in_state, out_state, round_key, Nr, (Nr - 6L), costing));
                    }
                    else
                    {
#line 786 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QAESWidestFinalRound.Apply((in_state, out_state, round_key, Nr, costing));
                    }

#line 789 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 791 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[0L][i]));
                    }

#line 794 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 796 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[1L][i]));
                    }

#line 799 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 801 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[2L][i]));
                    }

#line 804 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 806 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(out_state[3L][i]));
                    }

#line 810 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 812 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 814 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, in_state[j][i]));
#line 815 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, out_state[j][i]));
#line 816 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 820 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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
#line 826 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 827 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 828 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 829 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 831 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (state,expanded_key,ciphertext) = (Allocate.Apply(((4L * 32L) * (Nr + 1L))), Allocate.Apply(((4L * 32L) * (Nr + 1L))), Allocate.Apply((4L * 32L)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 833 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 835 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 837 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_message[((j * 32L) + i)], state[((j * 32L) + i)]));
                        }
                    }

#line 840 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, (Nk - 1L)))
#line hidden
                    {
#line 842 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 844 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_key[((j * 32L) + i)], expanded_key[((j * 32L) + i)]));
                        }
                    }

#line 849 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QAESWidestRijndael.Apply((expanded_key, state, ciphertext, Nr, Nk, costing));
#line 851 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 853 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((0L * 32L) + i)]));
                    }

#line 856 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 858 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((1L * 32L) + i)]));
                    }

#line 861 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 863 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((2L * 32L) + i)]));
                    }

#line 866 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 868 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((3L * 32L) + i)]));
                    }

#line 872 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 874 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 876 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, state[((j * 32L) + i)]));
#line 877 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, ciphertext[((j * 32L) + i)]));
                        }
                    }

#line 880 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, (Nk - 1L)))
#line hidden
                    {
#line 882 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 884 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 888 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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
#line 894 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_1 = QArray<Result>.Create(32L);
#line 895 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_2 = QArray<Result>.Create(32L);
#line 896 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_3 = QArray<Result>.Create(32L);
#line 897 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res_4 = QArray<Result>.Create(32L);
#line hidden
            {
#line 899 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (state,key,ciphertext) = (Allocate.Apply(((4L * 32L) * (in_place_mixcolumn ? (Nr + 1L) : (2L * Nr)))), Allocate.Apply((Nk * 32L)), Allocate.Apply((4L * 32L)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 901 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 903 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 905 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_message[((j * 32L) + i)], state[((j * 32L) + i)]));
                        }
                    }

#line 908 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, (Nk - 1L)))
#line hidden
                    {
#line 910 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 912 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_key[((j * 32L) + i)], key[((j * 32L) + i)]));
                        }
                    }

#line 916 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QAESSmartWideRijndael.Apply((key, state, ciphertext, Nr, Nk, in_place_mixcolumn, costing));
#line 918 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 920 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_1.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((0L * 32L) + i)]));
                    }

#line 923 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 925 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_2.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((1L * 32L) + i)]));
                    }

#line 928 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 930 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_3.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((2L * 32L) + i)]));
                    }

#line 933 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, 31L))
#line hidden
                    {
#line 935 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res_4.Modify(i, MicrosoftQuantumIntrinsicM.Apply(ciphertext[((3L * 32L) + i)]));
                    }

#line 939 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, 3L))
#line hidden
                    {
#line 941 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 943 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, ciphertext[((j * 32L) + i)]));
                        }
                    }

#line 946 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, (((4L * 32L) * (in_place_mixcolumn ? (Nr + 1L) : (2L * Nr))) - 1L)))
#line hidden
                    {
#line 948 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, state[j]));
                    }

#line 950 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, (Nk - 1L)))
#line hidden
                    {
#line 952 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 31L))
#line hidden
                        {
#line 954 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 958 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

    public partial class SmartWideGroverOracle : Operation<(IQArray<Result>,IQArray<Result>,IQArray<Boolean>,Int64,Int64,Int64,Boolean,Boolean), Result>, ICallable
    {
        public SmartWideGroverOracle(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,IQArray<Result>,IQArray<Boolean>,Int64,Int64,Int64,Boolean,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,IQArray<Result>,IQArray<Boolean>,Int64,Int64,Int64,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "SmartWideGroverOracle";
        String ICallable.FullName => "QTests.AES.SmartWideGroverOracle";
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

        protected ICallable<(IQArray<Qubit>,Qubit,IQArray<Qubit>,IQArray<Boolean>,Int64,Int64,Int64,Boolean,Boolean), QVoid> QAESSmartWideGroverOracle
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,IQArray<Result>,IQArray<Boolean>,Int64,Int64,Int64,Boolean,Boolean), Result> Body => (__in__) =>
        {
            var (_key,_plaintexts,target_ciphertext,pairs,Nr,Nk,in_place_mixcolumn,costing) = __in__;
#line 963 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res = Result.Zero;
#line hidden
            {
#line 965 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (key,success,plaintext) = (Allocate.Apply((Nk * 32L)), Allocate.Apply(), Allocate.Apply((128L * pairs)));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 967 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, ((Nk * 32L) - 1L)))
#line hidden
                    {
#line 969 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_key[i], key[i]));
                    }

#line 971 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, (pairs - 1L)))
#line hidden
                    {
#line 973 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 127L))
#line hidden
                        {
#line 975 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((_plaintexts[((128L * j) + i)], plaintext[((128L * j) + i)]));
                        }
                    }

#line 980 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QAESSmartWideGroverOracle.Apply((key, success, plaintext, target_ciphertext, pairs, Nr, Nk, in_place_mixcolumn, costing));
#line 982 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    res = MicrosoftQuantumIntrinsicM.Apply(success);
#line 984 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QUtilitiesSet.Apply((Result.Zero, success));
#line 985 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(0L, ((Nk * 32L) - 1L)))
#line hidden
                    {
#line 987 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, key[i]));
                    }

#line 989 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var j in new Range(0L, (pairs - 1L)))
#line hidden
                    {
#line 991 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        foreach (var i in new Range(0L, 127L))
#line hidden
                        {
#line 993 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            QUtilitiesSet.Apply((Result.Zero, plaintext[((128L * j) + i)]));
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
                    Release.Apply(key);
#line hidden
                    Release.Apply(success);
#line hidden
                    Release.Apply(plaintext);
                }
            }

#line 997 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QAESSmartWideGroverOracle = this.Factory.Get<ICallable<(IQArray<Qubit>,Qubit,IQArray<Qubit>,IQArray<Boolean>,Int64,Int64,Int64,Boolean,Boolean), QVoid>>(typeof(QAES.SmartWide.GroverOracle));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,IQArray<Result>,IQArray<Boolean>,Int64,Int64,Int64,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__, IQArray<Result> _key, IQArray<Result> _plaintexts, IQArray<Boolean> target_ciphertext, Int64 pairs, Int64 Nr, Int64 Nk, Boolean in_place_mixcolumn, Boolean costing)
        {
            return __m__.Run<SmartWideGroverOracle, (IQArray<Result>,IQArray<Result>,IQArray<Boolean>,Int64,Int64,Int64,Boolean,Boolean), Result>((_key, _plaintexts, target_ciphertext, pairs, Nr, Nk, in_place_mixcolumn, costing));
        }
    }
}

#line hidden
namespace QTests.GF256
{
    public partial class Inverse : Operation<(IQArray<Result>,Boolean), IQArray<Result>>, ICallable
    {
        public Inverse(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Inverse";
        String ICallable.FullName => "QTests.GF256.Inverse";
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

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> QGF256Sixteenth
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,Boolean), IQArray<Result>> Body => (__in__) =>
        {
            var (_a,costing) = __in__;
#line 13 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(8L);
#line hidden
            {
#line 14 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (a,b) = (Allocate.Apply(8L), Allocate.Apply(8L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 16 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 18 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_a[(i - 1L)], a[(i - 1L)]));
                    }

#line 21 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QGF256Sixteenth.Apply((a, b, costing));
#line 23 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 25 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res.Modify((i - 1L), MicrosoftQuantumIntrinsicM.Apply(b[(i - 1L)]));
                    }

#line 29 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 31 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, a[(i - 1L)]));
#line 32 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, b[(i - 1L)]));
                    }

#line 34 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    return res;
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
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QGF256Sixteenth = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(QGF256.Sixteenth));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, IQArray<Result> _a, Boolean costing)
        {
            return __m__.Run<Inverse, (IQArray<Result>,Boolean), IQArray<Result>>((_a, costing));
        }
    }

    public partial class Mul : Operation<(IQArray<Result>,IQArray<Result>,Boolean,Boolean), IQArray<Result>>, ICallable
    {
        public Mul(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,IQArray<Result>,Boolean,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,IQArray<Result>,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Mul";
        String ICallable.FullName => "QTests.GF256.Mul";
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

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)> QGF256Mul
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)> QGF256UnrolledMul
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,IQArray<Result>,Boolean,Boolean), IQArray<Result>> Body => (__in__) =>
        {
            var (_a,_b,unrolled,costing) = __in__;
#line 40 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(8L);
#line hidden
            {
#line 41 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (a,b,c) = (Allocate.Apply(8L), Allocate.Apply(8L), Allocate.Apply(8L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 43 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 45 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_a[(i - 1L)], a[(i - 1L)]));
#line 46 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_b[(i - 1L)], b[(i - 1L)]));
                    }

#line 49 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    if (unrolled)
                    {
#line 51 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QGF256UnrolledMul.Apply((a, b, c, costing));
                    }
                    else
                    {
#line 55 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QGF256Mul.Apply((a, b, c, costing));
                    }

#line 58 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 60 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res.Modify((i - 1L), MicrosoftQuantumIntrinsicM.Apply(c[(i - 1L)]));
                    }

#line 64 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 66 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, a[(i - 1L)]));
#line 67 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, b[(i - 1L)]));
#line 68 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, c[(i - 1L)]));
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
#line hidden
                    Release.Apply(c);
                }
            }

#line 71 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QGF256Mul = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(QGF256.Mul));
            this.QGF256UnrolledMul = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(QGF256.UnrolledMul));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,IQArray<Result>,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, IQArray<Result> _a, IQArray<Result> _b, Boolean unrolled, Boolean costing)
        {
            return __m__.Run<Mul, (IQArray<Result>,IQArray<Result>,Boolean,Boolean), IQArray<Result>>((_a, _b, unrolled, costing));
        }
    }

    public partial class Square : Operation<(IQArray<Result>,Boolean,Boolean), IQArray<Result>>, ICallable
    {
        public Square(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,Boolean,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Square";
        String ICallable.FullName => "QTests.GF256.Square";
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

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> QGF256Square
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Boolean)> QGF256InPlaceSquare
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
            var (_a,in_place,costing) = __in__;
#line 76 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(8L);
#line hidden
            {
#line 77 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (a,b) = (Allocate.Apply(8L), Allocate.Apply(8L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 79 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 81 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_a[(i - 1L)], a[(i - 1L)]));
                    }

#line 84 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    if (in_place)
                    {
#line 86 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QGF256InPlaceSquare.Apply((a, costing));
                    }
                    else
                    {
#line 90 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QGF256Square.Apply((a, b, costing));
                    }

#line 93 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 95 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        if (in_place)
                        {
#line 97 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            res.Modify((i - 1L), MicrosoftQuantumIntrinsicM.Apply(a[(i - 1L)]));
                        }
                        else
                        {
#line 101 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            res.Modify((i - 1L), MicrosoftQuantumIntrinsicM.Apply(b[(i - 1L)]));
                        }
                    }

#line 106 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 108 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, a[(i - 1L)]));
#line 109 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 112 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QGF256Square = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(QGF256.Square));
            this.QGF256InPlaceSquare = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Boolean)>>(typeof(QGF256.InPlace.Square));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, IQArray<Result> _a, Boolean in_place, Boolean costing)
        {
            return __m__.Run<Square, (IQArray<Result>,Boolean,Boolean), IQArray<Result>>((_a, in_place, costing));
        }
    }

    public partial class Fourth : Operation<(IQArray<Result>,Boolean,Boolean), IQArray<Result>>, ICallable
    {
        public Fourth(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,Boolean,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Fourth";
        String ICallable.FullName => "QTests.GF256.Fourth";
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

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> QGF256Inverse24
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,Boolean)> QGF256InPlaceFourth
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
            var (_a,in_place,costing) = __in__;
#line 117 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(8L);
#line hidden
            {
#line 118 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (a,b) = (Allocate.Apply(8L), Allocate.Apply(8L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 120 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 122 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_a[(i - 1L)], a[(i - 1L)]));
                    }

#line 125 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    if (in_place)
                    {
#line 127 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QGF256InPlaceFourth.Apply((a, costing));
                    }
                    else
                    {
#line 131 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QGF256Inverse24.Apply((a, b, costing));
                    }

#line 134 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 136 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        if (in_place)
                        {
#line 138 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            res.Modify((i - 1L), MicrosoftQuantumIntrinsicM.Apply(a[(i - 1L)]));
                        }
                        else
                        {
#line 142 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            res.Modify((i - 1L), MicrosoftQuantumIntrinsicM.Apply(b[(i - 1L)]));
                        }
                    }

#line 147 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 149 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, a[(i - 1L)]));
#line 150 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 153 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QGF256Inverse24 = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(QGF256.Inverse24));
            this.QGF256InPlaceFourth = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Boolean)>>(typeof(QGF256.InPlace.Fourth));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, IQArray<Result> _a, Boolean in_place, Boolean costing)
        {
            return __m__.Run<Fourth, (IQArray<Result>,Boolean,Boolean), IQArray<Result>>((_a, in_place, costing));
        }
    }

    public partial class Sixteenth : Operation<(IQArray<Result>,Boolean), IQArray<Result>>, ICallable
    {
        public Sixteenth(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Sixteenth";
        String ICallable.FullName => "QTests.GF256.Sixteenth";
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

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> QGF256Sixteenth
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> QUtilitiesSet
        {
            get;
            set;
        }

        public override Func<(IQArray<Result>,Boolean), IQArray<Result>> Body => (__in__) =>
        {
            var (_a,costing) = __in__;
#line 158 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(8L);
#line hidden
            {
#line 159 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (a,b) = (Allocate.Apply(8L), Allocate.Apply(8L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 161 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 163 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_a[(i - 1L)], a[(i - 1L)]));
                    }

#line 166 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    QGF256Sixteenth.Apply((a, b, costing));
#line 168 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 170 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        res.Modify((i - 1L), MicrosoftQuantumIntrinsicM.Apply(b[(i - 1L)]));
                    }

#line 174 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 176 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, a[(i - 1L)]));
#line 177 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 180 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QGF256Sixteenth = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(QGF256.Sixteenth));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, IQArray<Result> _a, Boolean costing)
        {
            return __m__.Run<Sixteenth, (IQArray<Result>,Boolean), IQArray<Result>>((_a, costing));
        }
    }

    public partial class SixtyFourth : Operation<(IQArray<Result>,Boolean,Boolean), IQArray<Result>>, ICallable
    {
        public SixtyFourth(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Result>,Boolean,Boolean)>, IApplyData
        {
            public In((IQArray<Result>,Boolean,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "SixtyFourth";
        String ICallable.FullName => "QTests.GF256.SixtyFourth";
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

        protected IAdjointable<(IQArray<Qubit>,Boolean)> QGF256InPlaceSixtyFourth
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
            var (_a,in_place,costing) = __in__;
#line 185 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            var res = QArray<Result>.Create(8L);
#line hidden
            {
#line 186 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                var (a,b) = (Allocate.Apply(8L), Allocate.Apply(8L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 188 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 190 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((_a[(i - 1L)], a[(i - 1L)]));
                    }

#line 193 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    if (in_place)
                    {
#line 195 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QGF256InPlaceSixtyFourth.Apply((a, costing));
                    }
                    else
                    {
                    }

#line 203 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 205 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        if (in_place)
                        {
#line 207 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            res.Modify((i - 1L), MicrosoftQuantumIntrinsicM.Apply(a[(i - 1L)]));
                        }
                        else
                        {
#line 211 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                            res.Modify((i - 1L), MicrosoftQuantumIntrinsicM.Apply(b[(i - 1L)]));
                        }
                    }

#line 216 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                    foreach (var i in new Range(1L, 8L))
#line hidden
                    {
#line 218 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
                        QUtilitiesSet.Apply((Result.Zero, a[(i - 1L)]));
#line 219 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
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

#line 222 "C:\\Users\\lizhenqiang\\Desktop\\grover-blocks-masterdepth - 副本 (2) - 副本 - 副本\\aes\\QTests.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QGF256InPlaceSixtyFourth = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Boolean)>>(typeof(QGF256.InPlace.SixtyFourth));
            this.QUtilitiesSet = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(QUtilities.Set));
        }

        public override IApplyData __dataIn((IQArray<Result>,Boolean,Boolean) data) => new In(data);
        public override IApplyData __dataOut(IQArray<Result> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Result>> Run(IOperationFactory __m__, IQArray<Result> _a, Boolean in_place, Boolean costing)
        {
            return __m__.Run<SixtyFourth, (IQArray<Result>,Boolean,Boolean), IQArray<Result>>((_a, in_place, costing));
        }
    }
}