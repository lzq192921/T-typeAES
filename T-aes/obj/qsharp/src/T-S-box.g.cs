#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Ttype\",\"Name\":\"DummySBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":10,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"output\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":55}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"DummySBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":12,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"DummySBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":51,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Ttype\",\"Name\":\"SBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":55,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"output\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":50},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"SBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":57,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"SBox\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":71,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Ttype\",\"Name\":\"SBox1\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":74,\"Item2\":5},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"input\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"output\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":40}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":58}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"SBox1\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":76,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"SBox1\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":91,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Ttype\",\"Name\":\"Mul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":94,\"Item2\":0},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":16}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":29}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"res\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":40},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"t\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":55}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"p\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":67}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":78},\"Item2\":{\"Line\":1,\"Column\":85}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"Mul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":96,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"Mul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":138,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Ttype\",\"Name\":\"Mull\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":141,\"Item2\":0},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":17}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"res\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":41},\"Item2\":{\"Line\":1,\"Column\":44}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"t\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"p\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":67},\"Item2\":{\"Line\":1,\"Column\":68}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":79},\"Item2\":{\"Line\":1,\"Column\":86}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"Mull\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":143,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"Mull\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":188,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Ttype\",\"Name\":\"ForwardMul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":193,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"t\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"p\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":59},\"Item2\":{\"Line\":1,\"Column\":60}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":71},\"Item2\":{\"Line\":1,\"Column\":78}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"ForwardMul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":195,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"ForwardMul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":217,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Ttype\",\"Name\":\"UnrolledMul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":220,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"res\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":51}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"t\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":62},\"Item2\":{\"Line\":1,\"Column\":63}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"p\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":74},\"Item2\":{\"Line\":1,\"Column\":75}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":86},\"Item2\":{\"Line\":1,\"Column\":93}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"UnrolledMul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":222,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"UnrolledMul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":260,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Ttype\",\"Name\":\"Inverse24\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":263,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"m\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":46}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":64}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"Inverse24\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":265,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"Inverse24\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":322,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Ttype\",\"Name\":\"inverse28\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":325,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":34}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":45},\"Item2\":{\"Line\":1,\"Column\":52}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"inverse28\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":327,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"inverse28\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":353,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Ttype\",\"Name\":\"inverse281\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":356,\"Item2\":0},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":21}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":53}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"inverse281\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":358,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Ttype\",\"Name\":\"inverse281\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":384,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"InPlace\",\"Name\":\"Constantmul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":397,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":24}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":35},\"Item2\":{\"Line\":1,\"Column\":42}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" <summary>\",\" Computes a^2 in place.\",\" </summary>\",\" <param name=\\\"a\\\">Input/Output register</param>\",\" <returns>Unit</returns>\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"InPlace\",\"Name\":\"Constantmul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":399,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"InPlace\",\"Name\":\"Constantmul\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":410,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"InPlace\",\"Name\":\"M\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":413,\"Item2\":0},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":12}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":13},\"Item2\":{\"Line\":1,\"Column\":14}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":44}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"InPlace\",\"Name\":\"M\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":415,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"InPlace\",\"Name\":\"M\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":446,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"InPlace\",\"Name\":\"AMinverse\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":451,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":21},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":40}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"InPlace\",\"Name\":\"AMinverse\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":453,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"InPlace\",\"Name\":\"AMinverse\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/T-S-box.qs\",\"Position\":{\"Item1\":503,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace Ttype
{
    public partial class DummySBox : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)>, ICallable
    {
        public DummySBox(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "DummySBox";
        String ICallable.FullName => "Ttype.DummySBox";
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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (input,output,n) = __in__;
#line 15 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            foreach (var i in new Range(1L, n))
#line hidden
            {
#line 17 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(input[0L]);
#line 18 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(input[1L]);
#line 19 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(input[2L]);
#line 20 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(input[3L]);
#line 21 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(input[4L]);
#line 22 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(input[5L]);
#line 23 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(input[6L]);
#line 24 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(input[7L]);
#line 26 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(output[0L]);
#line 27 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(output[1L]);
#line 28 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(output[2L]);
#line 29 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(output[3L]);
#line 30 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(output[4L]);
#line 31 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(output[5L]);
#line 32 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(output[6L]);
#line 33 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicT.Apply(output[7L]);
#line 35 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((input[0L], input[1L]));
#line 36 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((input[1L], input[2L]));
#line 37 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((input[2L], input[3L]));
#line 38 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((input[3L], input[4L]));
#line 39 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((input[4L], input[5L]));
#line 40 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((input[5L], input[6L]));
#line 41 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((input[6L], input[7L]));
#line 42 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((input[7L], output[0L]));
#line 43 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((output[0L], output[1L]));
#line 44 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((output[1L], output[2L]));
#line 45 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((output[2L], output[3L]));
#line 46 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((output[3L], output[4L]));
#line 47 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((output[4L], output[5L]));
#line 48 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((output[5L], output[6L]));
#line 49 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((output[6L], output[7L]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (input,output,n) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(1L, n)))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((output[6L], output[7L]));
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((output[5L], output[6L]));
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((output[4L], output[5L]));
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((output[3L], output[4L]));
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((output[2L], output[3L]));
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((output[1L], output[2L]));
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((output[0L], output[1L]));
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((input[7L], output[0L]));
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((input[6L], input[7L]));
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((input[5L], input[6L]));
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((input[4L], input[5L]));
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((input[3L], input[4L]));
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((input[2L], input[3L]));
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((input[1L], input[2L]));
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((input[0L], input[1L]));
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(output[7L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(output[6L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(output[5L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(output[4L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(output[3L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(output[2L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(output[1L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(output[0L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(input[7L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(input[6L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(input[5L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(input[4L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(input[3L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(input[2L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(input[1L]);
#line hidden
                MicrosoftQuantumIntrinsicT.Adjoint.Apply(input[0L]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicT = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.T));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> input, IQArray<Qubit> output, Int64 n)
        {
            return __m__.Run<DummySBox, (IQArray<Qubit>,IQArray<Qubit>,Int64), QVoid>((input, output, n));
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
        String ICallable.FullName => "Ttype.SBox";
        protected IAdjointable<(IQArray<Qubit>,Boolean)> InPlaceAMinverse
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> InPlaceM
        {
            get;
            set;
        }

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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> inverse28
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (input,output,costing) = __in__;
#line hidden
            {
#line 60 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                var (c,e,f,g,h,t) = (Allocate.Apply(12L), Allocate.Apply(21L), Allocate.Apply(8L), Allocate.Apply(15L), Allocate.Apply(15L), Allocate.Apply(8L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 62 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    InPlaceM.Apply((input, t, costing));
#line 63 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    inverse28.Apply((t, output, costing));
#line 64 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    InPlaceAMinverse.Apply((output, costing));
#line 65 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    InPlaceM.Adjoint.Apply((input, t, costing));
#line 66 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    MicrosoftQuantumIntrinsicX.Apply(output[0L]);
#line 67 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    MicrosoftQuantumIntrinsicX.Apply(output[1L]);
#line 68 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    MicrosoftQuantumIntrinsicX.Apply(output[5L]);
#line 69 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    MicrosoftQuantumIntrinsicX.Apply(output[6L]);
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
                    Release.Apply(c);
#line hidden
                    Release.Apply(e);
#line hidden
                    Release.Apply(f);
#line hidden
                    Release.Apply(g);
#line hidden
                    Release.Apply(h);
#line hidden
                    Release.Apply(t);
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
                var (c,e,f,g,h,t) = (Allocate.Apply(12L), Allocate.Apply(21L), Allocate.Apply(8L), Allocate.Apply(15L), Allocate.Apply(15L), Allocate.Apply(8L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(output[6L]);
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(output[5L]);
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(output[1L]);
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(output[0L]);
#line hidden
                    InPlaceM.Adjoint.Adjoint.Apply((input, t, costing));
#line hidden
                    InPlaceAMinverse.Adjoint.Apply((output, costing));
#line hidden
                    inverse28.Adjoint.Apply((t, output, costing));
#line hidden
                    InPlaceM.Adjoint.Apply((input, t, costing));
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
                    Release.Apply(c);
#line hidden
                    Release.Apply(e);
#line hidden
                    Release.Apply(f);
#line hidden
                    Release.Apply(g);
#line hidden
                    Release.Apply(h);
#line hidden
                    Release.Apply(t);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.InPlaceAMinverse = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Boolean)>>(typeof(InPlace.AMinverse));
            this.InPlaceM = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(InPlace.M));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.inverse28 = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(inverse28));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> input, IQArray<Qubit> output, Boolean costing)
        {
            return __m__.Run<SBox, (IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((input, output, costing));
        }
    }

    public partial class SBox1 : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public SBox1(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "SBox1";
        String ICallable.FullName => "Ttype.SBox1";
        protected IAdjointable<(IQArray<Qubit>,Boolean)> InPlaceAMinverse
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> InPlaceM
        {
            get;
            set;
        }

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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)> inverse281
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (input,output,costing) = __in__;
#line hidden
            {
#line 79 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                var (c,e,f,g,h,t) = (Allocate.Apply(12L), Allocate.Apply(21L), Allocate.Apply(8L), Allocate.Apply(15L), Allocate.Apply(15L), Allocate.Apply(8L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 81 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    InPlaceM.Apply((input, t, costing));
#line 82 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    InPlaceAMinverse.Adjoint.Apply((output, costing));
#line 83 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    inverse281.Apply((t, output, costing));
#line 84 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    InPlaceAMinverse.Apply((output, costing));
#line 85 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    InPlaceM.Adjoint.Apply((input, t, costing));
#line 86 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    MicrosoftQuantumIntrinsicX.Apply(output[0L]);
#line 87 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    MicrosoftQuantumIntrinsicX.Apply(output[1L]);
#line 88 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    MicrosoftQuantumIntrinsicX.Apply(output[5L]);
#line 89 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    MicrosoftQuantumIntrinsicX.Apply(output[6L]);
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
                    Release.Apply(c);
#line hidden
                    Release.Apply(e);
#line hidden
                    Release.Apply(f);
#line hidden
                    Release.Apply(g);
#line hidden
                    Release.Apply(h);
#line hidden
                    Release.Apply(t);
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
                var (c,e,f,g,h,t) = (Allocate.Apply(12L), Allocate.Apply(21L), Allocate.Apply(8L), Allocate.Apply(15L), Allocate.Apply(15L), Allocate.Apply(8L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(output[6L]);
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(output[5L]);
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(output[1L]);
#line hidden
                    MicrosoftQuantumIntrinsicX.Adjoint.Apply(output[0L]);
#line hidden
                    InPlaceM.Adjoint.Adjoint.Apply((input, t, costing));
#line hidden
                    InPlaceAMinverse.Adjoint.Apply((output, costing));
#line hidden
                    inverse281.Adjoint.Apply((t, output, costing));
#line hidden
                    InPlaceAMinverse.Adjoint.Adjoint.Apply((output, costing));
#line hidden
                    InPlaceM.Adjoint.Apply((input, t, costing));
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
                    Release.Apply(c);
#line hidden
                    Release.Apply(e);
#line hidden
                    Release.Apply(f);
#line hidden
                    Release.Apply(g);
#line hidden
                    Release.Apply(h);
#line hidden
                    Release.Apply(t);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.InPlaceAMinverse = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Boolean)>>(typeof(InPlace.AMinverse));
            this.InPlaceM = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(InPlace.M));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.inverse281 = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(inverse281));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> input, IQArray<Qubit> output, Boolean costing)
        {
            return __m__.Run<SBox1, (IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((input, output, costing));
        }
    }

    public partial class Mul : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public Mul(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "Mul";
        String ICallable.FullName => "Ttype.Mul";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
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

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (a,b,res,t,p,costing) = __in__;
#line 99 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[0L], a[1L], t[0L]));
#line 100 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[1L], a[3L], t[1L]));
#line 101 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[2L], a[0L], t[2L]));
#line 102 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[3L], a[2L], t[3L]));
#line 103 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((t[0L], t[3L], t[4L]));
#line 106 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[0L], b[1L], t[5L]));
#line 107 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[1L], b[3L], t[6L]));
#line 108 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[2L], b[0L], t[7L]));
#line 109 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[3L], b[2L], t[8L]));
#line 110 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((t[5L], t[8L], t[9L]));
#line 113 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[0L], b[0L], p[0L], costing));
#line 114 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[1L], b[1L], p[1L], costing));
#line 115 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[2L], b[2L], p[2L], costing));
#line 116 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[3L], b[3L], p[3L], costing));
#line 117 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[3L], t[8L], p[4L], costing));
#line 120 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[1L], t[6L], res[0L], costing));
#line 121 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[0L], t[5L], res[1L], costing));
#line 122 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[2L], t[7L], res[2L], costing));
#line 123 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[4L], t[9L], res[3L], costing));
#line 126 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[0L], res[0L]));
#line 127 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[4L], res[2L]));
#line 128 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((res[1L], res[3L]));
#line 129 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((res[0L], res[1L]));
#line 130 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((res[2L], res[3L]));
#line 131 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[1L], res[0L]));
#line 132 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[4L], res[1L]));
#line 133 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[0L], res[2L]));
#line 134 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[1L], res[2L]));
#line 135 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[2L], res[0L]));
#line 136 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((res[0L], res[3L]));
#line 137 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[3L], res[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,res,t,p,costing) = __in__;
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
            QUtilitiesLPAND.Adjoint.Apply((t[4L], t[9L], res[3L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[2L], t[7L], res[2L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[0L], t[5L], res[1L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[1L], t[6L], res[0L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[3L], t[8L], p[4L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[3L], b[3L], p[3L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[2L], b[2L], p[2L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[1L], b[1L], p[1L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[0L], b[0L], p[0L], costing));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((t[5L], t[8L], t[9L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[3L], b[2L], t[8L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[2L], b[0L], t[7L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[1L], b[3L], t[6L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[0L], b[1L], t[5L]));
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
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.QUtilitiesLPAND = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit,Boolean)>>(typeof(QUtilities.LPAND));
            this.QUtilitiesLPXOR = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(QUtilities.LPXOR));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, IQArray<Qubit> res, IQArray<Qubit> t, IQArray<Qubit> p, Boolean costing)
        {
            return __m__.Run<Mul, (IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((a, b, res, t, p, costing));
        }
    }

    public partial class Mull : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public Mull(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "Mull";
        String ICallable.FullName => "Ttype.Mull";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
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

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (a,b,res,t,p,costing) = __in__;
#line 146 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((res[0L], res[1L]));
#line 147 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((res[1L], res[3L]));
#line 148 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((res[2L], res[3L]));
#line 149 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[0L], a[1L], t[0L]));
#line 150 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[1L], a[3L], t[1L]));
#line 151 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[2L], a[0L], t[2L]));
#line 152 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[3L], a[2L], t[3L]));
#line 153 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((t[0L], t[3L], t[4L]));
#line 156 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[0L], b[1L], t[5L]));
#line 157 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[1L], b[3L], t[6L]));
#line 158 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[2L], b[0L], t[7L]));
#line 159 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[3L], b[2L], t[8L]));
#line 160 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((t[5L], t[8L], t[9L]));
#line 163 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[0L], b[0L], p[0L], costing));
#line 164 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[1L], b[1L], p[1L], costing));
#line 165 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[2L], b[2L], p[2L], costing));
#line 166 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[3L], b[3L], p[3L], costing));
#line 167 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[3L], t[8L], p[4L], costing));
#line 170 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[1L], t[6L], res[0L], costing));
#line 171 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[0L], t[5L], res[1L], costing));
#line 172 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[2L], t[7L], res[2L], costing));
#line 173 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[4L], t[9L], res[3L], costing));
#line 176 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[0L], res[0L]));
#line 177 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[4L], res[2L]));
#line 178 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((res[1L], res[3L]));
#line 179 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((res[0L], res[1L]));
#line 180 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((res[2L], res[3L]));
#line 181 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[1L], res[0L]));
#line 182 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[4L], res[1L]));
#line 183 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[0L], res[2L]));
#line 184 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[1L], res[2L]));
#line 185 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[2L], res[0L]));
#line 186 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((res[0L], res[3L]));
#line 187 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[3L], res[0L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,res,t,p,costing) = __in__;
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
            QUtilitiesLPAND.Adjoint.Apply((t[4L], t[9L], res[3L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[2L], t[7L], res[2L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[0L], t[5L], res[1L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[1L], t[6L], res[0L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[3L], t[8L], p[4L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[3L], b[3L], p[3L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[2L], b[2L], p[2L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[1L], b[1L], p[1L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[0L], b[0L], p[0L], costing));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((t[5L], t[8L], t[9L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[3L], b[2L], t[8L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[2L], b[0L], t[7L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[1L], b[3L], t[6L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[0L], b[1L], t[5L]));
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
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((res[2L], res[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((res[1L], res[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((res[0L], res[1L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.QUtilitiesLPAND = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit,Boolean)>>(typeof(QUtilities.LPAND));
            this.QUtilitiesLPXOR = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(QUtilities.LPXOR));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, IQArray<Qubit> res, IQArray<Qubit> t, IQArray<Qubit> p, Boolean costing)
        {
            return __m__.Run<Mull, (IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((a, b, res, t, p, costing));
        }
    }

    public partial class ForwardMul : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public ForwardMul(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits);
        }

        String ICallable.Name => "ForwardMul";
        String ICallable.FullName => "Ttype.ForwardMul";
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

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (a,b,t,p,costing) = __in__;
#line 198 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[0L], a[1L], t[0L]));
#line 199 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[1L], a[3L], t[1L]));
#line 200 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[2L], a[0L], t[2L]));
#line 201 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[3L], a[2L], t[3L]));
#line 202 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((t[0L], t[3L], t[4L]));
#line 205 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[0L], b[1L], t[5L]));
#line 206 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[1L], b[3L], t[6L]));
#line 207 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[2L], b[0L], t[7L]));
#line 208 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[3L], b[2L], t[8L]));
#line 209 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((t[5L], t[8L], t[9L]));
#line 212 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[0L], b[0L], p[0L], costing));
#line 213 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[1L], b[1L], p[1L], costing));
#line 214 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[2L], b[2L], p[2L], costing));
#line 215 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[3L], b[3L], p[3L], costing));
#line 216 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[3L], t[8L], p[4L], costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,t,p,costing) = __in__;
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[3L], t[8L], p[4L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[3L], b[3L], p[3L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[2L], b[2L], p[2L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[1L], b[1L], p[1L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[0L], b[0L], p[0L], costing));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((t[5L], t[8L], t[9L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[3L], b[2L], t[8L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[2L], b[0L], t[7L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[1L], b[3L], t[6L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[0L], b[1L], t[5L]));
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
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.QUtilitiesLPAND = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit,Boolean)>>(typeof(QUtilities.LPAND));
            this.QUtilitiesLPXOR = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(QUtilities.LPXOR));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, IQArray<Qubit> t, IQArray<Qubit> p, Boolean costing)
        {
            return __m__.Run<ForwardMul, (IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((a, b, t, p, costing));
        }
    }

    public partial class UnrolledMul : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public UnrolledMul(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits, ((IApplyData)Data.Item4)?.Qubits, ((IApplyData)Data.Item5)?.Qubits);
        }

        String ICallable.Name => "UnrolledMul";
        String ICallable.FullName => "Ttype.UnrolledMul";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
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

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (a,b,res,t,p,costing) = __in__;
#line 225 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[0L], a[1L], t[0L]));
#line 226 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[1L], a[3L], t[1L]));
#line 227 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[2L], a[0L], t[2L]));
#line 228 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[3L], a[2L], t[3L]));
#line 229 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((t[0L], t[3L], t[4L]));
#line 232 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[0L], b[1L], t[5L]));
#line 233 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[1L], b[3L], t[6L]));
#line 234 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[2L], b[0L], t[7L]));
#line 235 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((b[3L], b[2L], t[8L]));
#line 236 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((t[5L], t[8L], t[9L]));
#line 239 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[3L], b[3L], res[0L], costing));
#line 240 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[0L], b[0L], res[1L], costing));
#line 241 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[3L], t[8L], res[2L], costing));
#line 242 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[2L], b[2L], res[3L], costing));
#line 245 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[1L], b[1L], p[0L], costing));
#line 246 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[0L], t[5L], p[1L], costing));
#line 247 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[1L], t[6L], p[2L], costing));
#line 248 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[2L], t[7L], p[3L], costing));
#line 249 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((t[4L], t[9L], p[4L], costing));
#line 251 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((res[2L], p[2L], p[1L]));
#line 252 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((res[1L], p[0L]));
#line 253 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[0L], p[3L]));
#line 254 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[3L], res[2L]));
#line 255 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((p[0L], res[3L], res[0L]));
#line 256 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[1L], res[1L]));
#line 257 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((p[3L], p[4L], res[3L]));
#line 258 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[2L], res[0L]));
#line 259 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((p[1L], res[3L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,res,t,p,costing) = __in__;
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
            QUtilitiesLPAND.Adjoint.Apply((t[4L], t[9L], p[4L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[2L], t[7L], p[3L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[1L], t[6L], p[2L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[0L], t[5L], p[1L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[1L], b[1L], p[0L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[2L], b[2L], res[3L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((t[3L], t[8L], res[2L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[0L], b[0L], res[1L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[3L], b[3L], res[0L], costing));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((t[5L], t[8L], t[9L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[3L], b[2L], t[8L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[2L], b[0L], t[7L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[1L], b[3L], t[6L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((b[0L], b[1L], t[5L]));
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
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.QUtilitiesLPAND = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit,Boolean)>>(typeof(QUtilities.LPAND));
            this.QUtilitiesLPXOR = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(QUtilities.LPXOR));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, IQArray<Qubit> res, IQArray<Qubit> t, IQArray<Qubit> p, Boolean costing)
        {
            return __m__.Run<UnrolledMul, (IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((a, b, res, t, p, costing));
        }
    }

    public partial class Inverse24 : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public Inverse24(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "Inverse24";
        String ICallable.FullName => "Ttype.Inverse24";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
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

        protected IAdjointable<(Qubit,Qubit,Boolean)> QUtilitiesREWIRE
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (a,b,m,costing) = __in__;
#line 269 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPXOR.Apply((a[0L], a[3L], a[2L]));
#line 270 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[3L]));
#line 271 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], a[1L]));
#line 272 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[3L]));
#line 275 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesREWIRE.Apply((a[0L], a[1L], costing));
#line 276 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesREWIRE.Apply((a[0L], a[3L], costing));
#line 277 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesREWIRE.Apply((a[0L], a[2L], costing));
#line 280 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], m[4L]));
#line 281 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], m[5L]));
#line 284 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[0L], a[2L], m[0L], costing));
#line 285 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((m[4L], a[3L], m[1L], costing));
#line 286 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((m[5L], a[1L], m[2L], costing));
#line 287 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((m[0L], m[3L]));
#line 288 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[0L]));
#line 289 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], a[2L]));
#line 290 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], m[5L]));
#line 294 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], m[4L]));
#line 295 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], m[0L]));
#line 296 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], m[3L]));
#line 299 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[0L], m[0L], b[3L], costing));
#line 300 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((m[4L], m[1L], b[2L], costing));
#line 301 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((a[2L], m[3L], b[1L], costing));
#line 302 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesLPAND.Apply((m[5L], m[2L], b[0L], costing));
#line 303 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], b[3L]));
#line 304 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], b[2L]));
#line 305 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], b[0L]));
#line 306 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], b[1L]));
#line 307 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], m[0L]));
#line 308 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((m[0L], b[0L]));
#line 309 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((m[0L], b[2L]));
#line 312 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((b[1L], b[2L]));
#line 313 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((b[0L], b[3L]));
#line 314 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((b[3L], b[2L]));
#line 315 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((b[1L], b[0L]));
#line 316 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((b[2L], b[0L]));
#line 319 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesREWIRE.Apply((b[0L], b[1L], costing));
#line 320 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesREWIRE.Apply((b[1L], b[3L], costing));
#line 321 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesREWIRE.Apply((b[2L], b[3L], costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,m,costing) = __in__;
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((b[2L], b[3L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((b[1L], b[3L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((b[0L], b[1L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((b[2L], b[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((b[1L], b[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((b[3L], b[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((b[0L], b[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((b[1L], b[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((m[0L], b[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((m[0L], b[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], m[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], b[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], b[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], b[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], b[3L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((m[5L], m[2L], b[0L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[2L], m[3L], b[1L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((m[4L], m[1L], b[2L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[0L], m[0L], b[3L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], m[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], m[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], m[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], m[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], a[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((m[0L], m[3L]));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((m[5L], a[1L], m[2L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((m[4L], a[3L], m[1L], costing));
#line hidden
            QUtilitiesLPAND.Adjoint.Apply((a[0L], a[2L], m[0L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], m[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], m[4L]));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[0L], a[2L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[0L], a[3L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[0L], a[1L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], a[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[3L]));
#line hidden
            QUtilitiesLPXOR.Adjoint.Apply((a[0L], a[3L], a[2L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.QUtilitiesLPAND = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit,Boolean)>>(typeof(QUtilities.LPAND));
            this.QUtilitiesLPXOR = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(QUtilities.LPXOR));
            this.QUtilitiesREWIRE = this.Factory.Get<IAdjointable<(Qubit,Qubit,Boolean)>>(typeof(QUtilities.REWIRE));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, IQArray<Qubit> m, Boolean costing)
        {
            return __m__.Run<Inverse24, (IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((a, b, m, costing));
        }
    }

    public partial class inverse28 : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public inverse28(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "inverse28";
        String ICallable.FullName => "Ttype.inverse28";
        protected IAdjointable<(IQArray<Qubit>,Boolean)> InPlaceConstantmul
        {
            get;
            set;
        }

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

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)> QUtilitiesCNOTnBits
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)> ForwardMul
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)> Inverse24
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)> Mul
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)> UnrolledMul
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (a,b,costing) = __in__;
#line hidden
            {
#line 330 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                var (c,e,f,g,h) = (Allocate.Apply(12L), Allocate.Apply(21L), Allocate.Apply(8L), Allocate.Apply(15L), Allocate.Apply(15L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 332 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), 4L));
#line 333 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(4L, 7L)), c?.Slice(new Range(4L, 7L)), 4L));
#line 334 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(4L, 7L)), a?.Slice(new Range(0L, 3L)), 4L));
#line 335 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    UnrolledMul.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), c?.Slice(new Range(8L, 11L)), e?.Slice(new Range(0L, 9L)), e?.Slice(new Range(10L, 14L)), costing));
#line 336 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    InPlaceConstantmul.Apply((c?.Slice(new Range(4L, 7L)), costing));
#line 337 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((c?.Slice(new Range(4L, 7L)), c?.Slice(new Range(8L, 11L)), 4L));
#line 338 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    Inverse24.Apply((c?.Slice(new Range(8L, 11L)), f?.Slice(new Range(0L, 3L)), e?.Slice(new Range(15L, 20L)), costing));
#line 339 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((f?.Slice(new Range(0L, 3L)), f?.Slice(new Range(4L, 7L)), 4L));
#line 340 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    Mul.Apply((a?.Slice(new Range(0L, 3L)), f?.Slice(new Range(0L, 3L)), b?.Slice(new Range(0L, 3L)), g?.Slice(new Range(0L, 9L)), g?.Slice(new Range(10L, 14L)), costing));
#line 341 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    Mul.Apply((a?.Slice(new Range(4L, 7L)), f?.Slice(new Range(4L, 7L)), b?.Slice(new Range(4L, 7L)), h?.Slice(new Range(0L, 9L)), h?.Slice(new Range(10L, 14L)), costing));
#line 342 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    ForwardMul.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), f?.Slice(new Range(0L, 3L)), g?.Slice(new Range(0L, 9L)), g?.Slice(new Range(10L, 14L)), costing));
#line 343 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    ForwardMul.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), f?.Slice(new Range(4L, 7L)), h?.Slice(new Range(0L, 9L)), h?.Slice(new Range(10L, 14L)), costing));
#line 344 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((f?.Slice(new Range(0L, 3L)), f?.Slice(new Range(4L, 7L)), 4L));
#line 345 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    Inverse24.Adjoint.Apply((c?.Slice(new Range(8L, 11L)), f?.Slice(new Range(0L, 3L)), e?.Slice(new Range(15L, 20L)), costing));
#line 346 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((c?.Slice(new Range(4L, 7L)), c?.Slice(new Range(8L, 11L)), 4L));
#line 347 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    InPlaceConstantmul.Adjoint.Apply((c?.Slice(new Range(4L, 7L)), costing));
#line 348 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    UnrolledMul.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), c?.Slice(new Range(8L, 11L)), e?.Slice(new Range(0L, 9L)), e?.Slice(new Range(10L, 14L)), costing));
#line 349 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(4L, 7L)), a?.Slice(new Range(0L, 3L)), 4L));
#line 350 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(4L, 7L)), c?.Slice(new Range(4L, 7L)), 4L));
#line 351 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), 4L));
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
                    Release.Apply(c);
#line hidden
                    Release.Apply(e);
#line hidden
                    Release.Apply(f);
#line hidden
                    Release.Apply(g);
#line hidden
                    Release.Apply(h);
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
                var (c,e,f,g,h) = (Allocate.Apply(12L), Allocate.Apply(21L), Allocate.Apply(8L), Allocate.Apply(15L), Allocate.Apply(15L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), 4L));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), c?.Slice(new Range(4L, 7L)), 4L));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), a?.Slice(new Range(0L, 3L)), 4L));
#line hidden
                    UnrolledMul.Adjoint.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), c?.Slice(new Range(8L, 11L)), e?.Slice(new Range(0L, 9L)), e?.Slice(new Range(10L, 14L)), costing));
#line hidden
                    InPlaceConstantmul.Adjoint.Adjoint.Apply((c?.Slice(new Range(4L, 7L)), costing));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((c?.Slice(new Range(4L, 7L)), c?.Slice(new Range(8L, 11L)), 4L));
#line hidden
                    Inverse24.Adjoint.Adjoint.Apply((c?.Slice(new Range(8L, 11L)), f?.Slice(new Range(0L, 3L)), e?.Slice(new Range(15L, 20L)), costing));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((f?.Slice(new Range(0L, 3L)), f?.Slice(new Range(4L, 7L)), 4L));
#line hidden
                    ForwardMul.Adjoint.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), f?.Slice(new Range(4L, 7L)), h?.Slice(new Range(0L, 9L)), h?.Slice(new Range(10L, 14L)), costing));
#line hidden
                    ForwardMul.Adjoint.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), f?.Slice(new Range(0L, 3L)), g?.Slice(new Range(0L, 9L)), g?.Slice(new Range(10L, 14L)), costing));
#line hidden
                    Mul.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), f?.Slice(new Range(4L, 7L)), b?.Slice(new Range(4L, 7L)), h?.Slice(new Range(0L, 9L)), h?.Slice(new Range(10L, 14L)), costing));
#line hidden
                    Mul.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), f?.Slice(new Range(0L, 3L)), b?.Slice(new Range(0L, 3L)), g?.Slice(new Range(0L, 9L)), g?.Slice(new Range(10L, 14L)), costing));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((f?.Slice(new Range(0L, 3L)), f?.Slice(new Range(4L, 7L)), 4L));
#line hidden
                    Inverse24.Adjoint.Apply((c?.Slice(new Range(8L, 11L)), f?.Slice(new Range(0L, 3L)), e?.Slice(new Range(15L, 20L)), costing));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((c?.Slice(new Range(4L, 7L)), c?.Slice(new Range(8L, 11L)), 4L));
#line hidden
                    InPlaceConstantmul.Adjoint.Apply((c?.Slice(new Range(4L, 7L)), costing));
#line hidden
                    UnrolledMul.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), c?.Slice(new Range(8L, 11L)), e?.Slice(new Range(0L, 9L)), e?.Slice(new Range(10L, 14L)), costing));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), a?.Slice(new Range(0L, 3L)), 4L));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), c?.Slice(new Range(4L, 7L)), 4L));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), 4L));
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
                    Release.Apply(c);
#line hidden
                    Release.Apply(e);
#line hidden
                    Release.Apply(f);
#line hidden
                    Release.Apply(g);
#line hidden
                    Release.Apply(h);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.InPlaceConstantmul = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Boolean)>>(typeof(InPlace.Constantmul));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QUtilitiesCNOTnBits = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)>>(typeof(QUtilities.CNOTnBits));
            this.ForwardMul = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(ForwardMul));
            this.Inverse24 = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(Inverse24));
            this.Mul = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(Mul));
            this.UnrolledMul = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(UnrolledMul));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, Boolean costing)
        {
            return __m__.Run<inverse28, (IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((a, b, costing));
        }
    }

    public partial class inverse281 : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public inverse281(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "inverse281";
        String ICallable.FullName => "Ttype.inverse281";
        protected IAdjointable<(IQArray<Qubit>,Boolean)> InPlaceConstantmul
        {
            get;
            set;
        }

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

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)> QUtilitiesCNOTnBits
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)> ForwardMul
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)> Inverse24
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)> Mull
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)> UnrolledMul
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (a,b,costing) = __in__;
#line hidden
            {
#line 361 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                var (c,e,f,g,h) = (Allocate.Apply(12L), Allocate.Apply(21L), Allocate.Apply(8L), Allocate.Apply(15L), Allocate.Apply(15L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 363 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), 4L));
#line 364 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(4L, 7L)), c?.Slice(new Range(4L, 7L)), 4L));
#line 365 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(4L, 7L)), a?.Slice(new Range(0L, 3L)), 4L));
#line 366 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    UnrolledMul.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), c?.Slice(new Range(8L, 11L)), e?.Slice(new Range(0L, 9L)), e?.Slice(new Range(10L, 14L)), costing));
#line 367 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    InPlaceConstantmul.Apply((c?.Slice(new Range(4L, 7L)), costing));
#line 368 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((c?.Slice(new Range(4L, 7L)), c?.Slice(new Range(8L, 11L)), 4L));
#line 369 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    Inverse24.Apply((c?.Slice(new Range(8L, 11L)), f?.Slice(new Range(0L, 3L)), e?.Slice(new Range(15L, 20L)), costing));
#line 370 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((f?.Slice(new Range(0L, 3L)), f?.Slice(new Range(4L, 7L)), 4L));
#line 371 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    Mull.Apply((a?.Slice(new Range(0L, 3L)), f?.Slice(new Range(0L, 3L)), b?.Slice(new Range(0L, 3L)), g?.Slice(new Range(0L, 9L)), g?.Slice(new Range(10L, 14L)), costing));
#line 372 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    Mull.Apply((a?.Slice(new Range(4L, 7L)), f?.Slice(new Range(4L, 7L)), b?.Slice(new Range(4L, 7L)), h?.Slice(new Range(0L, 9L)), h?.Slice(new Range(10L, 14L)), costing));
#line 373 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    ForwardMul.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), f?.Slice(new Range(0L, 3L)), g?.Slice(new Range(0L, 9L)), g?.Slice(new Range(10L, 14L)), costing));
#line 374 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    ForwardMul.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), f?.Slice(new Range(4L, 7L)), h?.Slice(new Range(0L, 9L)), h?.Slice(new Range(10L, 14L)), costing));
#line 375 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((f?.Slice(new Range(0L, 3L)), f?.Slice(new Range(4L, 7L)), 4L));
#line 376 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    Inverse24.Adjoint.Apply((c?.Slice(new Range(8L, 11L)), f?.Slice(new Range(0L, 3L)), e?.Slice(new Range(15L, 20L)), costing));
#line 377 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((c?.Slice(new Range(4L, 7L)), c?.Slice(new Range(8L, 11L)), 4L));
#line 378 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    InPlaceConstantmul.Adjoint.Apply((c?.Slice(new Range(4L, 7L)), costing));
#line 379 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    UnrolledMul.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), c?.Slice(new Range(8L, 11L)), e?.Slice(new Range(0L, 9L)), e?.Slice(new Range(10L, 14L)), costing));
#line 380 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(4L, 7L)), a?.Slice(new Range(0L, 3L)), 4L));
#line 381 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(4L, 7L)), c?.Slice(new Range(4L, 7L)), 4L));
#line 382 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
                    QUtilitiesCNOTnBits.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), 4L));
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
                    Release.Apply(c);
#line hidden
                    Release.Apply(e);
#line hidden
                    Release.Apply(f);
#line hidden
                    Release.Apply(g);
#line hidden
                    Release.Apply(h);
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
                var (c,e,f,g,h) = (Allocate.Apply(12L), Allocate.Apply(21L), Allocate.Apply(8L), Allocate.Apply(15L), Allocate.Apply(15L));
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), 4L));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), c?.Slice(new Range(4L, 7L)), 4L));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), a?.Slice(new Range(0L, 3L)), 4L));
#line hidden
                    UnrolledMul.Adjoint.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), c?.Slice(new Range(8L, 11L)), e?.Slice(new Range(0L, 9L)), e?.Slice(new Range(10L, 14L)), costing));
#line hidden
                    InPlaceConstantmul.Adjoint.Adjoint.Apply((c?.Slice(new Range(4L, 7L)), costing));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((c?.Slice(new Range(4L, 7L)), c?.Slice(new Range(8L, 11L)), 4L));
#line hidden
                    Inverse24.Adjoint.Adjoint.Apply((c?.Slice(new Range(8L, 11L)), f?.Slice(new Range(0L, 3L)), e?.Slice(new Range(15L, 20L)), costing));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((f?.Slice(new Range(0L, 3L)), f?.Slice(new Range(4L, 7L)), 4L));
#line hidden
                    ForwardMul.Adjoint.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), f?.Slice(new Range(4L, 7L)), h?.Slice(new Range(0L, 9L)), h?.Slice(new Range(10L, 14L)), costing));
#line hidden
                    ForwardMul.Adjoint.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), f?.Slice(new Range(0L, 3L)), g?.Slice(new Range(0L, 9L)), g?.Slice(new Range(10L, 14L)), costing));
#line hidden
                    Mull.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), f?.Slice(new Range(4L, 7L)), b?.Slice(new Range(4L, 7L)), h?.Slice(new Range(0L, 9L)), h?.Slice(new Range(10L, 14L)), costing));
#line hidden
                    Mull.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), f?.Slice(new Range(0L, 3L)), b?.Slice(new Range(0L, 3L)), g?.Slice(new Range(0L, 9L)), g?.Slice(new Range(10L, 14L)), costing));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((f?.Slice(new Range(0L, 3L)), f?.Slice(new Range(4L, 7L)), 4L));
#line hidden
                    Inverse24.Adjoint.Apply((c?.Slice(new Range(8L, 11L)), f?.Slice(new Range(0L, 3L)), e?.Slice(new Range(15L, 20L)), costing));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((c?.Slice(new Range(4L, 7L)), c?.Slice(new Range(8L, 11L)), 4L));
#line hidden
                    InPlaceConstantmul.Adjoint.Apply((c?.Slice(new Range(4L, 7L)), costing));
#line hidden
                    UnrolledMul.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), c?.Slice(new Range(8L, 11L)), e?.Slice(new Range(0L, 9L)), e?.Slice(new Range(10L, 14L)), costing));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), a?.Slice(new Range(0L, 3L)), 4L));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(4L, 7L)), c?.Slice(new Range(4L, 7L)), 4L));
#line hidden
                    QUtilitiesCNOTnBits.Adjoint.Apply((a?.Slice(new Range(0L, 3L)), c?.Slice(new Range(0L, 3L)), 4L));
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
                    Release.Apply(c);
#line hidden
                    Release.Apply(e);
#line hidden
                    Release.Apply(f);
#line hidden
                    Release.Apply(g);
#line hidden
                    Release.Apply(h);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.InPlaceConstantmul = this.Factory.Get<IAdjointable<(IQArray<Qubit>,Boolean)>>(typeof(InPlace.Constantmul));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.QUtilitiesCNOTnBits = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)>>(typeof(QUtilities.CNOTnBits));
            this.ForwardMul = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(ForwardMul));
            this.Inverse24 = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(Inverse24));
            this.Mull = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(Mull));
            this.UnrolledMul = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,IQArray<Qubit>,Boolean)>>(typeof(UnrolledMul));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> a, IQArray<Qubit> b, Boolean costing)
        {
            return __m__.Run<inverse281, (IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((a, b, costing));
        }
    }
}

#line hidden
namespace InPlace
{
    public partial class Constantmul : Adjointable<(IQArray<Qubit>,Boolean)>, ICallable
    {
        public Constantmul(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "Constantmul";
        String ICallable.FullName => "InPlace.Constantmul";
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
#line 402 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[2L]));
#line 403 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], a[1L]));
#line 404 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[3L]));
#line 407 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesREWIRE.Apply((a[0L], a[1L], costing));
#line 408 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesREWIRE.Apply((a[0L], a[2L], costing));
#line 409 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
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
            return __m__.Run<Constantmul, (IQArray<Qubit>,Boolean), QVoid>((a, costing));
        }
    }

    public partial class M : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public M(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "M";
        String ICallable.FullName => "InPlace.M";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (a,b,costing) = __in__;
#line 418 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[7L], b[7L]));
#line 419 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], b[5L]));
#line 420 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[5L], b[4L]));
#line 421 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[4L], b[3L]));
#line 422 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], b[6L]));
#line 423 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], b[1L]));
#line 424 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], b[2L]));
#line 425 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], b[0L]));
#line 427 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[7L], b[2L]));
#line 428 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[5L], b[7L]));
#line 429 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[4L], b[0L]));
#line 430 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], b[4L]));
#line 431 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], b[3L]));
#line 432 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], b[1L]));
#line 435 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[5L], b[0L]));
#line 436 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[4L], b[4L]));
#line 437 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], b[6L]));
#line 438 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], b[5L]));
#line 440 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[7L], b[6L]));
#line 441 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], b[0L]));
#line 442 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[4L], b[5L]));
#line 444 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[7L], b[5L]));
#line 445 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[5L], b[6L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,costing) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[5L], b[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[7L], b[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[4L], b[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], b[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[7L], b[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], b[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], b[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[4L], b[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[5L], b[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], b[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], b[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], b[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[4L], b[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[5L], b[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[7L], b[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], b[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], b[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], b[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], b[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[4L], b[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[5L], b[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], b[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[7L], b[7L]));
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
            return __m__.Run<M, (IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((a, b, costing));
        }
    }

    public partial class AMinverse : Adjointable<(IQArray<Qubit>,Boolean)>, ICallable
    {
        public AMinverse(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "AMinverse";
        String ICallable.FullName => "InPlace.AMinverse";
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
#line 456 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], a[6L]));
#line 457 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], a[7L]));
#line 458 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[5L]));
#line 460 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], a[7L]));
#line 461 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[6L]));
#line 462 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], a[5L]));
#line 465 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], a[5L]));
#line 466 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[4L]));
#line 467 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], a[6L]));
#line 469 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], a[7L]));
#line 470 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[1L], a[3L]));
#line 472 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[4L], a[7L]));
#line 473 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[0L], a[1L]));
#line 474 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[5L], a[6L]));
#line 476 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[4L], a[5L]));
#line 477 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], a[0L]));
#line 478 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[7L], a[3L]));
#line 481 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[7L], a[0L]));
#line 482 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], a[3L]));
#line 485 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[7L], a[1L]));
#line 486 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[6L], a[2L]));
#line 489 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[7L], a[4L]));
#line 490 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[2L], a[0L]));
#line 493 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[3L], a[2L]));
#line 494 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[5L], a[4L]));
#line 495 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a[7L], a[6L]));
#line 498 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesREWIRE.Apply((a[0L], a[6L], costing));
#line 499 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesREWIRE.Apply((a[4L], a[5L], costing));
#line 500 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesREWIRE.Apply((a[1L], a[3L], costing));
#line 501 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesREWIRE.Apply((a[3L], a[7L], costing));
#line 502 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\T-S-box.qs"
            QUtilitiesREWIRE.Apply((a[2L], a[4L], costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (a,costing) = __in__;
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[2L], a[4L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[3L], a[7L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[1L], a[3L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[4L], a[5L], costing));
#line hidden
            QUtilitiesREWIRE.Adjoint.Apply((a[0L], a[6L], costing));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[7L], a[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[5L], a[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], a[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], a[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[7L], a[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], a[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[7L], a[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], a[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[7L], a[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[7L], a[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], a[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[4L], a[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[5L], a[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], a[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[4L], a[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[6L], a[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], a[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], a[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[0L], a[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[6L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], a[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[1L], a[5L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[2L], a[7L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a[3L], a[6L]));
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
            return __m__.Run<AMinverse, (IQArray<Qubit>,Boolean), QVoid>((a, costing));
        }
    }
}