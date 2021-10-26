#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"Set\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":16},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"Set\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"SWAPBytes\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":14,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"SWAPBytes\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":15,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"SWAPBytes\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":22,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"CNOTBytes\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":25,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"CNOTBytes\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":26,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"CNOTBytes\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":33,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"CNOTnBits\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":36,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":20}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":22},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"n\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":47}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"CNOTnBits\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":37,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"CNOTnBits\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":44,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"REWIRE\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":47,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":19},\"Item2\":{\"Line\":1,\"Column\":20}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":30}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"free\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":43}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"REWIRE\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":48,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"REWIRE\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":55,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"REWIREBytes\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":58,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":24},\"Item2\":{\"Line\":1,\"Column\":25}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"free\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":52}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"REWIREBytes\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":59,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"REWIREBytes\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":66,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"ccnot\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":69,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"x\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":18}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"y\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":28}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"z\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":37},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":54}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"ccnot\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":70,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"ccnot\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":82,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"LPXOR\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":89,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_2\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"outp\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":48}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"LPXOR\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":91,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"LPXOR\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":96,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"LPXNOR\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":100,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_2\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"outp\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":48}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"LPXNOR\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":102,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"LPXNOR\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":107,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"LPAND\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":110,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":18},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"in_2\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"outp\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":44},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":57},\"Item2\":{\"Line\":1,\"Column\":64}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"LPAND\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":112,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"LPAND\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":124,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"LinearPrepare\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":129,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"a\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"b\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":36},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"c\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":47},\"Item2\":{\"Line\":1,\"Column\":48}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"d\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":58},\"Item2\":{\"Line\":1,\"Column\":59}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"LinearPrepare\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":129,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"LinearPrepare\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":129,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":79},\"Item2\":{\"Line\":1,\"Column\":82}},\"Documentation\":[\"automatically generated QsAdjoint specialization for QUtilities.LinearPrepare\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"AND\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":136,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"control1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":23}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"control2\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":57}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"AND\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":137,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"AND\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":150,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"ccnot_7_t_depth_4\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":178,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"control1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":38}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"control2\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":48},\"Item2\":{\"Line\":1,\"Column\":56}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":66},\"Item2\":{\"Line\":1,\"Column\":72}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"ccnot_7_t_depth_4\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":179,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"ccnot_7_t_depth_4\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":197,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"ccnot_7_t_depth_4\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":178,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":92},\"Item2\":{\"Line\":1,\"Column\":95}},\"Documentation\":[\"automatically generated QsControlled specialization for QUtilities.ccnot_7_t_depth_4\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":true,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"ccnot_7_t_depth_4\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":178,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for QUtilities.ccnot_7_t_depth_4\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"ccnot_T_depth_1\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":212,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"control1\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":36}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"control2\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":54}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":64},\"Item2\":{\"Line\":1,\"Column\":70}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"ccnot_T_depth_1\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":212,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"ccnot_T_depth_1\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":212,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":90},\"Item2\":{\"Line\":1,\"Column\":99}},\"Documentation\":[\"automatically generated QsAdjoint specialization for QUtilities.ccnot_T_depth_1\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"ccnot_T_depth_1\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":212,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":90},\"Item2\":{\"Line\":1,\"Column\":99}},\"Documentation\":[\"automatically generated QsControlled specialization for QUtilities.ccnot_T_depth_1\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"ccnot_T_depth_1\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":212,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":90},\"Item2\":{\"Line\":1,\"Column\":99}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for QUtilities.ccnot_T_depth_1\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"TDepthOneCCNOTOuterCircuit\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":225,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # See Also\",\" - Used as a part of @\\\"Microsoft.Quantum.Samples.UnitTesting.TDepthOneCCNOT\\\"\",\" - For the circuit diagram see Figure 1 on\",\"   [ Page 3 of arXiv:1210.0974v2 ](https://arxiv.org/pdf/1210.0974v2.pdf#page=2)\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"TDepthOneCCNOTOuterCircuit\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":225,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"TDepthOneCCNOTOuterCircuit\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":225,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsAdjoint specialization for QUtilities.TDepthOneCCNOTOuterCircuit\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"TDepthOneCCNOTOuterCircuit\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":225,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsControlled specialization for QUtilities.TDepthOneCCNOTOuterCircuit\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"TDepthOneCCNOTOuterCircuit\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":225,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for QUtilities.TDepthOneCCNOTOuterCircuit\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"TDepthOneCCNOTInnerCircuit\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":243,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":41}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # See Also\",\" - Used as a part of @\\\"Microsoft.Quantum.Samples.UnitTesting.TDepthOneCCNOT\\\"\",\" - For the circuit diagram see Figure 1 on\",\"   [ Page 3 of arXiv:1210.0974v2 ](https://arxiv.org/pdf/1210.0974v2.pdf#page=2)\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"TDepthOneCCNOTInnerCircuit\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":243,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":37}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"TDepthOneCCNOTInnerCircuit\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":243,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsAdjoint specialization for QUtilities.TDepthOneCCNOTInnerCircuit\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"TDepthOneCCNOTInnerCircuit\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":243,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsControlled specialization for QUtilities.TDepthOneCCNOTInnerCircuit\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"TDepthOneCCNOTInnerCircuit\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":243,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":63},\"Item2\":{\"Line\":1,\"Column\":72}},\"Documentation\":[\"automatically generated QsControlledAdjoint specialization for QUtilities.TDepthOneCCNOTInnerCircuit\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"CompressControls\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":270,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":27}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"controlQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":41}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"blankControlQubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":71}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"output\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":83},\"Item2\":{\"Line\":1,\"Column\":89}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":99},\"Item2\":{\"Line\":1,\"Column\":106}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Flips a blank output qubit if and only if all input\",\" control qubits are in the 1 state. Uses clean ancilla\",\" which are returned dirty.\",\"\",\" # Inputs\",\" ## controlQubits\",\" Array of qubits acting like a controlled X on the output\",\" ## blankControlQubits\",\" Qubits initialized to 0 which are used as ancilla.\",\" ## output\",\" A qubit, assumed to be 0, which is flipped if all control\",\" qubits are 1\",\"\",\" # Remarks\",\" Identical in function to (Controlled X)(controlQubits, (output))\",\" except the depth is lower, the output must be 0, and it uses\",\" ancilla which are not uncomputed.\",\" If controlQubits has n qubits, then this needs n-2\",\" blankControlQubits.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"CompressControls\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":271,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"CompressControls\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":293,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"TestIfAllOnes\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":310,\"Item2\":1},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"xs\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":27}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"output\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":39},\"Item2\":{\"Line\":1,\"Column\":45}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":55},\"Item2\":{\"Line\":1,\"Column\":62}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"Qubit\"},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[\" # Summary\",\" Checks if the input register is all ones, and if so,\",\" flips the output qubit from 0 to 1.\",\" # Inputs\",\" ## xs\",\" Qubit register being checked against all-zeros\",\" ## output\",\" The qubit that will be flipped\",\"\",\" # Remarks\",\" This has the same function as (Controlled X)(xs, (output))\",\" but this explicitly forms a binary tree to achieve a logarithmic\",\" depth. This means it borrows n-1 clean qubits.\"]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"TestIfAllOnes\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":311,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlled\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"TestIfAllOnes\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":325,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":11}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsControlledAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"TestIfAllOnes\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":328,\"Item2\":2},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"Union\",\"Fields\":[{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Controllable\"}]}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"TestIfAllOnes\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":310,\"Item2\":1},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[\"automatically generated QsAdjoint specialization for QUtilities.TestIfAllOnes\"]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"QUtilities\",\"Name\":\"CompareQubitstring\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":332,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":29}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"success\"]},\"Type\":{\"Case\":\"Qubit\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":30},\"Item2\":{\"Line\":1,\"Column\":37}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubitstring\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":46},\"Item2\":{\"Line\":1,\"Column\":57}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"target\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":68},\"Item2\":{\"Line\":1,\"Column\":74}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"costing\"]},\"Type\":{\"Case\":\"Bool\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":84},\"Item2\":{\"Line\":1,\"Column\":91}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Qubit\"},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"Bool\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"CompareQubitstring\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":334,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":5}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsAdjoint\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Affiliation\":{\"Case\":\"SimpleSet\",\"Fields\":[{\"Case\":\"Adjointable\"}]},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"QUtilities\",\"Name\":\"CompareQubitstring\"},\"SourceFile\":\"C:/Users/lizhenqiang/Desktop/copyaes%20-%20%E5%89%AF%E6%9C%AC/aes/QUtilities.qs\",\"Position\":{\"Item1\":365,\"Item2\":8},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":1},\"Item2\":{\"Line\":1,\"Column\":8}},\"Documentation\":[]}")]
#line hidden
namespace QUtilities
{
    public partial class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "QUtilities.Set";
        protected ICallable<Qubit, Result> MicrosoftQuantumIntrinsicM
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in__) =>
        {
            var (desired,q1) = __in__;
#line 10 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            if ((desired != MicrosoftQuantumIntrinsicM.Apply(q1)))
            {
#line 11 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumIntrinsicX.Apply(q1);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }

    public partial class SWAPBytes : Adjointable<(IQArray<Qubit>,IQArray<Qubit>)>, ICallable
    {
        public SWAPBytes(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "SWAPBytes";
        String ICallable.FullName => "QUtilities.SWAPBytes";
        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicSWAP
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 18 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            foreach (var i in new Range(0L, 7L))
#line hidden
            {
#line 20 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumIntrinsicSWAP.Apply((x[i], y[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, 7L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicSWAP.Adjoint.Apply((x[i], y[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.SWAP));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, IQArray<Qubit> y)
        {
            return __m__.Run<SWAPBytes, (IQArray<Qubit>,IQArray<Qubit>), QVoid>((x, y));
        }
    }

    public partial class CNOTBytes : Adjointable<(IQArray<Qubit>,IQArray<Qubit>)>, ICallable
    {
        public CNOTBytes(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "CNOTBytes";
        String ICallable.FullName => "QUtilities.CNOTBytes";
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

        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> Body => (__in__) =>
        {
            var (x,y) = __in__;
#line 29 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            foreach (var i in new Range(0L, 7L))
#line hidden
            {
#line 31 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((x[i], y[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, 7L)))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((x[i], y[i]));
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

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, IQArray<Qubit> y)
        {
            return __m__.Run<CNOTBytes, (IQArray<Qubit>,IQArray<Qubit>), QVoid>((x, y));
        }
    }

    public partial class CNOTnBits : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Int64)>, ICallable
    {
        public CNOTnBits(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Int64)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "CNOTnBits";
        String ICallable.FullName => "QUtilities.CNOTnBits";
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

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Int64), QVoid> Body => (__in__) =>
        {
            var (x,y,n) = __in__;
#line 40 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            foreach (var i in new Range(0L, (n - 1L)))
#line hidden
            {
#line 42 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((x[i], y[i]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Int64), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,n) = __in__;
#line hidden
            foreach (var i in RangeReverse.Apply(new Range(0L, (n - 1L))))
#line hidden
            {
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((x[i], y[i]));
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

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, IQArray<Qubit> y, Int64 n)
        {
            return __m__.Run<CNOTnBits, (IQArray<Qubit>,IQArray<Qubit>,Int64), QVoid>((x, y, n));
        }
    }

    public partial class REWIRE : Adjointable<(Qubit,Qubit,Boolean)>, ICallable
    {
        public REWIRE(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Boolean)>, IApplyData
        {
            public In((Qubit,Qubit,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "REWIRE";
        String ICallable.FullName => "QUtilities.REWIRE";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicSWAP
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Boolean), QVoid> Body => (__in__) =>
        {
            var (x,y,free) = __in__;
#line 51 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            if (!(free))
            {
#line 53 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumIntrinsicSWAP.Apply((x, y));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,free) = __in__;
#line hidden
            if (!(free))
            {
#line hidden
                MicrosoftQuantumIntrinsicSWAP.Adjoint.Apply((x, y));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.SWAP));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit x, Qubit y, Boolean free)
        {
            return __m__.Run<REWIRE, (Qubit,Qubit,Boolean), QVoid>((x, y, free));
        }
    }

    public partial class REWIREBytes : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, ICallable
    {
        public REWIREBytes(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "REWIREBytes";
        String ICallable.FullName => "QUtilities.REWIREBytes";
        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>)> SWAPBytes
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> Body => (__in__) =>
        {
            var (x,y,free) = __in__;
#line 62 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            if (!(free))
            {
#line 64 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                SWAPBytes.Apply((x, y));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,free) = __in__;
#line hidden
            if (!(free))
            {
#line hidden
                SWAPBytes.Adjoint.Apply((x, y));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.SWAPBytes = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>)>>(typeof(SWAPBytes));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> x, IQArray<Qubit> y, Boolean free)
        {
            return __m__.Run<REWIREBytes, (IQArray<Qubit>,IQArray<Qubit>,Boolean), QVoid>((x, y, free));
        }
    }

    public partial class ccnot : Adjointable<(Qubit,Qubit,Qubit,Boolean)>, ICallable
    {
        public ccnot(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Qubit,Boolean)>, IApplyData
        {
            public In((Qubit,Qubit,Qubit,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                    yield return Data.Item3;
                }
            }
        }

        String ICallable.Name => "ccnot";
        String ICallable.FullName => "QUtilities.ccnot";
        protected IUnitary<(Qubit,Qubit,Qubit)> MicrosoftQuantumIntrinsicCCNOT
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit,Qubit)> ccnot_T_depth_1
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit,Boolean), QVoid> Body => (__in__) =>
        {
            var (x,y,z,costing) = __in__;
#line 73 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            if (costing)
            {
#line 75 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                ccnot_T_depth_1.Apply((x, y, z));
            }
            else
            {
#line 80 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumIntrinsicCCNOT.Apply((x, y, z));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (x,y,z,costing) = __in__;
#line hidden
            if (costing)
            {
#line hidden
                ccnot_T_depth_1.Adjoint.Apply((x, y, z));
            }
            else
            {
#line hidden
                MicrosoftQuantumIntrinsicCCNOT.Adjoint.Apply((x, y, z));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CCNOT));
            this.ccnot_T_depth_1 = this.Factory.Get<IUnitary<(Qubit,Qubit,Qubit)>>(typeof(ccnot_T_depth_1));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit x, Qubit y, Qubit z, Boolean costing)
        {
            return __m__.Run<ccnot, (Qubit,Qubit,Qubit,Boolean), QVoid>((x, y, z, costing));
        }
    }

    public partial class LPXOR : Adjointable<(Qubit,Qubit,Qubit)>, ICallable
    {
        public LPXOR(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                    yield return Data.Item3;
                }
            }
        }

        String ICallable.Name => "LPXOR";
        String ICallable.FullName => "QUtilities.LPXOR";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit), QVoid> Body => (__in__) =>
        {
            var (in_1,in_2,outp) = __in__;
#line 94 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((in_1, outp));
#line 95 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((in_2, outp));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (in_1,in_2,outp) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((in_2, outp));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((in_1, outp));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit in_1, Qubit in_2, Qubit outp)
        {
            return __m__.Run<LPXOR, (Qubit,Qubit,Qubit), QVoid>((in_1, in_2, outp));
        }
    }

    public partial class LPXNOR : Adjointable<(Qubit,Qubit,Qubit)>, ICallable
    {
        public LPXNOR(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                    yield return Data.Item3;
                }
            }
        }

        String ICallable.Name => "LPXNOR";
        String ICallable.FullName => "QUtilities.LPXNOR";
        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit)> LPXOR
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit), QVoid> Body => (__in__) =>
        {
            var (in_1,in_2,outp) = __in__;
#line 105 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            LPXOR.Apply((in_1, in_2, outp));
#line 106 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicX.Apply(outp);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (in_1,in_2,outp) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicX.Adjoint.Apply(outp);
#line hidden
            LPXOR.Adjoint.Apply((in_1, in_2, outp));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.LPXOR = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(LPXOR));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit in_1, Qubit in_2, Qubit outp)
        {
            return __m__.Run<LPXNOR, (Qubit,Qubit,Qubit), QVoid>((in_1, in_2, outp));
        }
    }

    public partial class LPAND : Adjointable<(Qubit,Qubit,Qubit,Boolean)>, ICallable
    {
        public LPAND(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Qubit,Boolean)>, IApplyData
        {
            public In((Qubit,Qubit,Qubit,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                    yield return Data.Item3;
                }
            }
        }

        String ICallable.Name => "LPAND";
        String ICallable.FullName => "QUtilities.LPAND";
        protected IAdjointable<(Qubit,Qubit,Qubit)> AND
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit,Boolean)> ccnot
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit,Boolean), QVoid> Body => (__in__) =>
        {
            var (in_1,in_2,outp,costing) = __in__;
#line 115 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            if (costing)
            {
#line 117 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                AND.Apply((in_1, in_2, outp));
            }
            else
            {
#line 122 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                ccnot.Apply((in_1, in_2, outp, costing));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (in_1,in_2,outp,costing) = __in__;
#line hidden
            if (costing)
            {
#line hidden
                AND.Adjoint.Apply((in_1, in_2, outp));
            }
            else
            {
#line hidden
                ccnot.Adjoint.Apply((in_1, in_2, outp, costing));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.AND = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit)>>(typeof(AND));
            this.ccnot = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit,Boolean)>>(typeof(ccnot));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit in_1, Qubit in_2, Qubit outp, Boolean costing)
        {
            return __m__.Run<LPAND, (Qubit,Qubit,Qubit,Boolean), QVoid>((in_1, in_2, outp, costing));
        }
    }

    public partial class LinearPrepare : Adjointable<(Qubit,Qubit,Qubit,Qubit)>, ICallable
    {
        public LinearPrepare(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                    yield return Data.Item3;
                    yield return Data.Item4;
                }
            }
        }

        String ICallable.Name => "LinearPrepare";
        String ICallable.FullName => "QUtilities.LinearPrepare";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit,Qubit), QVoid> Body => (__in__) =>
        {
            var (a,b,c,d) = __in__;
#line 131 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((b, d));
#line 132 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((c, a));
#line 133 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((c, b));
#line 134 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((a, d));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (a,b,c,d) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((a, d));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((c, b));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((c, a));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((b, d));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit a, Qubit b, Qubit c, Qubit d)
        {
            return __m__.Run<LinearPrepare, (Qubit,Qubit,Qubit,Qubit), QVoid>((a, b, c, d));
        }
    }

    public partial class AND : Adjointable<(Qubit,Qubit,Qubit)>, ICallable
    {
        public AND(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                    yield return Data.Item3;
                }
            }
        }

        String ICallable.Name => "AND";
        String ICallable.FullName => "QUtilities.AND";
        protected ICallable<Result, Boolean> MicrosoftQuantumCanonIsResultOne
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Pauli>,IQArray<Qubit>,Result,Double,String,Double)> MicrosoftQuantumIntrinsicAssertProb
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
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

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicS
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicX
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit,Qubit)> LinearPrepare
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit), QVoid> Body => (__in__) =>
        {
            var (control1,control2,target) = __in__;
#line hidden
            {
#line 139 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                var anc = Allocate.Apply();
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 140 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    MicrosoftQuantumIntrinsicH.Apply(target);
#line 141 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    LinearPrepare.Apply((control1, control2, target, anc));
#line 142 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    MicrosoftQuantumIntrinsicT.Adjoint.Apply(control1);
#line 143 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    MicrosoftQuantumIntrinsicT.Adjoint.Apply(control2);
#line 144 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    MicrosoftQuantumIntrinsicT.Apply(target);
#line 145 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    MicrosoftQuantumIntrinsicT.Apply(anc);
#line 146 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    LinearPrepare.Adjoint.Apply((control1, control2, target, anc));
#line 147 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    MicrosoftQuantumIntrinsicH.Apply(target);
#line 148 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    MicrosoftQuantumIntrinsicS.Apply(target);
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
                    Release.Apply(anc);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (control1,control2,target) = __in__;
#line 152 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicH.Apply(target);
#line 153 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicAssertProb.Apply((new QArray<Pauli>(Pauli.PauliZ), new QArray<Qubit>(target), Result.One, 0.5D, "Probability of the measurement must be 0.5", 1E-10D));
#line 154 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            if (MicrosoftQuantumCanonIsResultOne.Apply(MicrosoftQuantumIntrinsicM.Apply(target)))
            {
#line 155 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumIntrinsicS.Apply(control1);
#line 156 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumIntrinsicS.Apply(control2);
#line 157 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((control1, control2));
#line 158 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumIntrinsicS.Adjoint.Apply(control2);
#line 159 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((control1, control2));
#line 160 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumIntrinsicX.Apply(target);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonIsResultOne = this.Factory.Get<ICallable<Result, Boolean>>(typeof(Microsoft.Quantum.Canon.IsResultOne));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicAssertProb = this.Factory.Get<IUnitary<(IQArray<Pauli>,IQArray<Qubit>,Result,Double,String,Double)>>(typeof(Microsoft.Quantum.Intrinsic.AssertProb));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicM = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Intrinsic.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.MicrosoftQuantumIntrinsicS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.S));
            this.MicrosoftQuantumIntrinsicT = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.T));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.LinearPrepare = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit,Qubit)>>(typeof(LinearPrepare));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit control1, Qubit control2, Qubit target)
        {
            return __m__.Run<AND, (Qubit,Qubit,Qubit), QVoid>((control1, control2, target));
        }
    }

    public partial class ccnot_7_t_depth_4 : Unitary<(Qubit,Qubit,Qubit)>, ICallable
    {
        public ccnot_7_t_depth_4(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                    yield return Data.Item3;
                }
            }
        }

        String ICallable.Name => "ccnot_7_t_depth_4";
        String ICallable.FullName => "QUtilities.ccnot_7_t_depth_4";
        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicT
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit), QVoid> Body => (__in__) =>
        {
            var (control1,control2,target) = __in__;
#line 181 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicT.Adjoint.Apply(control1);
#line 182 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicT.Adjoint.Apply(control2);
#line 183 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicH.Apply(target);
#line 184 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((target, control1));
#line 185 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicT.Apply(control1);
#line 186 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((control2, target));
#line 187 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((control2, control1));
#line 188 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicT.Apply(target);
#line 189 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicT.Adjoint.Apply(control1);
#line 190 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((control2, target));
#line 191 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((target, control1));
#line 192 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicT.Adjoint.Apply(target);
#line 193 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicT.Apply(control1);
#line 194 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicH.Apply(target);
#line 195 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((control2, control1));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit), QVoid> AdjointBody => Body;
        public override Func<(IQArray<Qubit>,(Qubit,Qubit,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(control1,control2,target)) = __in__;
#line hidden
            MicrosoftQuantumIntrinsicT.Adjoint.Controlled.Apply((__controlQubits__, control1));
#line hidden
            MicrosoftQuantumIntrinsicT.Adjoint.Controlled.Apply((__controlQubits__, control2));
#line hidden
            MicrosoftQuantumIntrinsicH.Controlled.Apply((__controlQubits__, target));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (target, control1)));
#line hidden
            MicrosoftQuantumIntrinsicT.Controlled.Apply((__controlQubits__, control1));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (control2, target)));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (control2, control1)));
#line hidden
            MicrosoftQuantumIntrinsicT.Controlled.Apply((__controlQubits__, target));
#line hidden
            MicrosoftQuantumIntrinsicT.Adjoint.Controlled.Apply((__controlQubits__, control1));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (control2, target)));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (target, control1)));
#line hidden
            MicrosoftQuantumIntrinsicT.Adjoint.Controlled.Apply((__controlQubits__, target));
#line hidden
            MicrosoftQuantumIntrinsicT.Controlled.Apply((__controlQubits__, control1));
#line hidden
            MicrosoftQuantumIntrinsicH.Controlled.Apply((__controlQubits__, target));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (control2, control1)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Qubit,Qubit,Qubit)), QVoid> ControlledAdjointBody => ControlledBody;
        public override void Init()
        {
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
            this.MicrosoftQuantumIntrinsicT = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.T));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit control1, Qubit control2, Qubit target)
        {
            return __m__.Run<ccnot_7_t_depth_4, (Qubit,Qubit,Qubit), QVoid>((control1, control2, target));
        }
    }

    public partial class ccnot_T_depth_1 : Unitary<(Qubit,Qubit,Qubit)>, ICallable
    {
        public ccnot_T_depth_1(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,Qubit,Qubit)>, IApplyData
        {
            public In((Qubit,Qubit,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item1;
                    yield return Data.Item2;
                    yield return Data.Item3;
                }
            }
        }

        String ICallable.Name => "ccnot_T_depth_1";
        String ICallable.FullName => "QUtilities.ccnot_T_depth_1";
        protected IUnitary MicrosoftQuantumCanonApplyWithCA
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

        protected IUnitary<IQArray<Qubit>> TDepthOneCCNOTInnerCircuit
        {
            get;
            set;
        }

        protected IUnitary<IQArray<Qubit>> TDepthOneCCNOTOuterCircuit
        {
            get;
            set;
        }

        public override Func<(Qubit,Qubit,Qubit), QVoid> Body => (__in__) =>
        {
            var (control1,control2,target) = __in__;
#line hidden
            {
#line 214 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                var auxillaryRegister = Allocate.Apply(4L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 217 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    MicrosoftQuantumCanonApplyWithCA.Apply((TDepthOneCCNOTOuterCircuit, TDepthOneCCNOTInnerCircuit, QArray<Qubit>.Add(auxillaryRegister, new QArray<Qubit>(target, control1, control2))));
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
                    Release.Apply(auxillaryRegister);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,Qubit,Qubit), QVoid> AdjointBody => (__in__) =>
        {
            var (control1,control2,target) = __in__;
#line hidden
            {
#line hidden
                var auxillaryRegister = Allocate.Apply(4L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    MicrosoftQuantumCanonApplyWithCA.Adjoint.Apply((TDepthOneCCNOTOuterCircuit, TDepthOneCCNOTInnerCircuit, QArray<Qubit>.Add(auxillaryRegister, new QArray<Qubit>(target, control1, control2))));
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
                    Release.Apply(auxillaryRegister);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Qubit,Qubit,Qubit)), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,(control1,control2,target)) = __in__;
#line hidden
            {
#line hidden
                var auxillaryRegister = Allocate.Apply(4L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    MicrosoftQuantumCanonApplyWithCA.Controlled.Apply((__controlQubits__, (TDepthOneCCNOTOuterCircuit, TDepthOneCCNOTInnerCircuit, QArray<Qubit>.Add(auxillaryRegister, new QArray<Qubit>(target, control1, control2)))));
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
                    Release.Apply(auxillaryRegister);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(Qubit,Qubit,Qubit)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,(control1,control2,target)) = __in__;
#line hidden
            {
#line hidden
                var auxillaryRegister = Allocate.Apply(4L);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line hidden
                    MicrosoftQuantumCanonApplyWithCA.Adjoint.Controlled.Apply((__controlQubits__, (TDepthOneCCNOTOuterCircuit, TDepthOneCCNOTInnerCircuit, QArray<Qubit>.Add(auxillaryRegister, new QArray<Qubit>(target, control1, control2)))));
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
                    Release.Apply(auxillaryRegister);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyWithCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyWithCA<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.TDepthOneCCNOTInnerCircuit = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(TDepthOneCCNOTInnerCircuit));
            this.TDepthOneCCNOTOuterCircuit = this.Factory.Get<IUnitary<IQArray<Qubit>>>(typeof(TDepthOneCCNOTOuterCircuit));
        }

        public override IApplyData __dataIn((Qubit,Qubit,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit control1, Qubit control2, Qubit target)
        {
            return __m__.Run<ccnot_T_depth_1, (Qubit,Qubit,Qubit), QVoid>((control1, control2, target));
        }
    }

    public partial class TDepthOneCCNOTOuterCircuit : Unitary<IQArray<Qubit>>, ICallable
    {
        public TDepthOneCCNOTOuterCircuit(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TDepthOneCCNOTOuterCircuit";
        String ICallable.FullName => "QUtilities.TDepthOneCCNOTOuterCircuit";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactI
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumIntrinsicCNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicH
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 227 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((qs.Length, 7L, "7 qubits are expected"));
#line 228 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicH.Apply(qs[4L]);
#line 229 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[5L], qs[1L]));
#line 230 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[6L], qs[3L]));
#line 231 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[5L], qs[2L]));
#line 232 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[4L], qs[1L]));
#line 233 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[3L], qs[0L]));
#line 234 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[6L], qs[2L]));
#line 235 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[4L], qs[0L]));
#line 236 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumIntrinsicCNOT.Apply((qs[1L], qs[3L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((qs.Length, 7L, "7 qubits are expected"));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[1L], qs[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[4L], qs[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[6L], qs[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[3L], qs[0L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[4L], qs[1L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[5L], qs[2L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[6L], qs[3L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((qs[5L], qs[1L]));
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Apply(qs[4L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((qs.Length, 7L, "7 qubits are expected"));
#line hidden
            MicrosoftQuantumIntrinsicH.Controlled.Apply((__controlQubits__, qs[4L]));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (qs[5L], qs[1L])));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (qs[6L], qs[3L])));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (qs[5L], qs[2L])));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (qs[4L], qs[1L])));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (qs[3L], qs[0L])));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (qs[6L], qs[2L])));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (qs[4L], qs[0L])));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Controlled.Apply((__controlQubits__, (qs[1L], qs[3L])));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((qs.Length, 7L, "7 qubits are expected"));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (qs[1L], qs[3L])));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (qs[4L], qs[0L])));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (qs[6L], qs[2L])));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (qs[3L], qs[0L])));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (qs[4L], qs[1L])));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (qs[5L], qs[2L])));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (qs[6L], qs[3L])));
#line hidden
            MicrosoftQuantumIntrinsicCNOT.Adjoint.Controlled.Apply((__controlQubits__, (qs[5L], qs[1L])));
#line hidden
            MicrosoftQuantumIntrinsicH.Adjoint.Controlled.Apply((__controlQubits__, qs[4L]));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.MicrosoftQuantumIntrinsicH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<TDepthOneCCNOTOuterCircuit, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class TDepthOneCCNOTInnerCircuit : Unitary<IQArray<Qubit>>, ICallable
    {
        public TDepthOneCCNOTInnerCircuit(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TDepthOneCCNOTInnerCircuit";
        String ICallable.FullName => "QUtilities.TDepthOneCCNOTInnerCircuit";
        protected IUnitary MicrosoftQuantumCanonApplyToEachCA
        {
            get;
            set;
        }

        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,String), QVoid> MicrosoftQuantumDiagnosticsEqualityFactI
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumIntrinsicT
        {
            get;
            set;
        }

        public override Func<IQArray<Qubit>, QVoid> Body => (__in__) =>
        {
            var qs = __in__;
#line 245 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((qs.Length, 7L, "7 qubits are expected"));
#line 246 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicT.Adjoint, qs?.Slice(new Range(0L, 2L))));
#line 247 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            MicrosoftQuantumCanonApplyToEachCA.Apply((MicrosoftQuantumIntrinsicT, qs?.Slice(new Range(3L, 6L))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<IQArray<Qubit>, QVoid> AdjointBody => (__in__) =>
        {
            var qs = __in__;
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((qs.Length, 7L, "7 qubits are expected"));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicT, qs?.Slice(new Range(3L, 6L))));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Apply((MicrosoftQuantumIntrinsicT.Adjoint, qs?.Slice(new Range(0L, 2L))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((qs.Length, 7L, "7 qubits are expected"));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicT.Adjoint, qs?.Slice(new Range(0L, 2L)))));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicT, qs?.Slice(new Range(3L, 6L)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (__controlQubits__,qs) = __in__;
#line hidden
            MicrosoftQuantumDiagnosticsEqualityFactI.Apply((qs.Length, 7L, "7 qubits are expected"));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicT, qs?.Slice(new Range(3L, 6L)))));
#line hidden
            MicrosoftQuantumCanonApplyToEachCA.Adjoint.Controlled.Apply((__controlQubits__, (MicrosoftQuantumIntrinsicT.Adjoint, qs?.Slice(new Range(0L, 2L)))));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonApplyToEachCA = this.Factory.Get<IUnitary>(typeof(Microsoft.Quantum.Canon.ApplyToEachCA<>));
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.MicrosoftQuantumDiagnosticsEqualityFactI = this.Factory.Get<ICallable<(Int64,Int64,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.EqualityFactI));
            this.MicrosoftQuantumIntrinsicT = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.T));
        }

        public override IApplyData __dataIn(IQArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qs)
        {
            return __m__.Run<TDepthOneCCNOTInnerCircuit, IQArray<Qubit>, QVoid>(qs);
        }
    }

    public partial class CompressControls : Adjointable<(IQArray<Qubit>,IQArray<Qubit>,Qubit,Boolean)>, ICallable
    {
        public CompressControls(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>,Qubit,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>,Qubit,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits, ((IApplyData)Data.Item3)?.Qubits);
        }

        String ICallable.Name => "CompressControls";
        String ICallable.FullName => "QUtilities.CompressControls";
        protected ICallable Length
        {
            get;
            set;
        }

        protected ICallable<Range, Range> RangeReverse
        {
            get;
            set;
        }

        protected ICallable<(Boolean,String), QVoid> MicrosoftQuantumDiagnosticsFact
        {
            get;
            set;
        }

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Qubit,Boolean)> self
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit,Boolean)> LPAND
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Qubit,Boolean), QVoid> Body => (__in__) =>
        {
            var (controlQubits,blankControlQubits,output,costing) = __in__;
#line 273 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            var nControls = controlQubits.Length;
#line 274 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            var nNewControls = blankControlQubits.Length;
#line 275 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            if ((nControls == 2L))
            {
#line 276 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                LPAND.Apply((controlQubits[0L], controlQubits[1L], output, costing));
            }
            else
            {
#line 278 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumDiagnosticsFact.Apply(((nNewControls >= (nControls / 2L)), String.Format("Cannot compress {0}\n\t\t\t\t\tcontrol qubits to {1} qubits without more ancilla", nControls, nNewControls)));
#line 280 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumDiagnosticsFact.Apply(((nNewControls <= nControls), String.Format("Cannot compress {0} control qubits into\n\t\t\t\t\t{1} qubits because there are too few controls", nControls, nNewControls)));
#line 283 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                var compressLength = (nControls - nNewControls);
#line 284 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                foreach (var idx in new Range(0L, 2L, (nControls - 2L)))
#line hidden
                {
#line 285 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    LPAND.Apply((controlQubits[idx], controlQubits[(idx + 1L)], blankControlQubits[(idx / 2L)], costing));
                }

#line 287 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                if (((nControls % 2L) == 0L))
                {
#line 288 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    self.Apply((blankControlQubits?.Slice(new Range(0L, ((nControls / 2L) - 1L))), blankControlQubits?.Slice(new Range((nControls / 2L), (nNewControls - 1L))), output, costing));
                }
                else
                {
#line 290 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    self.Apply((QArray<Qubit>.Add(new QArray<Qubit>(controlQubits[(nControls - 1L)]), blankControlQubits?.Slice(new Range(0L, ((nControls / 2L) - 1L)))), blankControlQubits?.Slice(new Range((nControls / 2L), (nNewControls - 1L))), output, costing));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,IQArray<Qubit>,Qubit,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (controlQubits,blankControlQubits,output,costing) = __in__;
#line hidden
            var nControls = controlQubits.Length;
#line hidden
            var nNewControls = blankControlQubits.Length;
#line hidden
            if ((nControls == 2L))
            {
#line hidden
                LPAND.Adjoint.Apply((controlQubits[0L], controlQubits[1L], output, costing));
            }
            else
            {
#line hidden
                MicrosoftQuantumDiagnosticsFact.Apply(((nNewControls >= (nControls / 2L)), String.Format("Cannot compress {0}\n\t\t\t\t\tcontrol qubits to {1} qubits without more ancilla", nControls, nNewControls)));
#line hidden
                MicrosoftQuantumDiagnosticsFact.Apply(((nNewControls <= nControls), String.Format("Cannot compress {0} control qubits into\n\t\t\t\t\t{1} qubits because there are too few controls", nControls, nNewControls)));
#line hidden
                var compressLength = (nControls - nNewControls);
#line hidden
                if (((nControls % 2L) == 0L))
                {
#line hidden
                    self.Adjoint.Apply((blankControlQubits?.Slice(new Range(0L, ((nControls / 2L) - 1L))), blankControlQubits?.Slice(new Range((nControls / 2L), (nNewControls - 1L))), output, costing));
                }
                else
                {
#line hidden
                    self.Adjoint.Apply((QArray<Qubit>.Add(new QArray<Qubit>(controlQubits[(nControls - 1L)]), blankControlQubits?.Slice(new Range(0L, ((nControls / 2L) - 1L)))), blankControlQubits?.Slice(new Range((nControls / 2L), (nNewControls - 1L))), output, costing));
                }

#line hidden
                foreach (var idx in RangeReverse.Apply(new Range(0L, 2L, (nControls - 2L))))
#line hidden
                {
#line hidden
                    LPAND.Adjoint.Apply((controlQubits[idx], controlQubits[(idx + 1L)], blankControlQubits[(idx / 2L)], costing));
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumDiagnosticsFact = this.Factory.Get<ICallable<(Boolean,String), QVoid>>(typeof(Microsoft.Quantum.Diagnostics.Fact));
            this.self = this;
            this.LPAND = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit,Boolean)>>(typeof(LPAND));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,IQArray<Qubit>,Qubit,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> controlQubits, IQArray<Qubit> blankControlQubits, Qubit output, Boolean costing)
        {
            return __m__.Run<CompressControls, (IQArray<Qubit>,IQArray<Qubit>,Qubit,Boolean), QVoid>((controlQubits, blankControlQubits, output, costing));
        }
    }

    public partial class TestIfAllOnes : Unitary<(IQArray<Qubit>,Qubit,Boolean)>, ICallable
    {
        public TestIfAllOnes(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,Qubit,Boolean)>, IApplyData
        {
            public In((IQArray<Qubit>,Qubit,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "TestIfAllOnes";
        String ICallable.FullName => "QUtilities.TestIfAllOnes";
        protected ICallable Length
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

        protected IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Qubit,Boolean)> CompressControls
        {
            get;
            set;
        }

        protected IUnitary<(IQArray<Qubit>,Qubit,Boolean)> self
        {
            get;
            set;
        }

        protected IAdjointable<(Qubit,Qubit,Qubit,Boolean)> ccnot
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,Qubit,Boolean), QVoid> Body => (__in__) =>
        {
            var (xs,output,costing) = __in__;
#line 313 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            var nQubits = xs.Length;
#line 314 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            if ((nQubits == 1L))
            {
#line 315 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                MicrosoftQuantumIntrinsicCNOT.Apply((xs[0L], output));
            }
            else if ((nQubits == 2L))
            {
#line 317 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                ccnot.Apply((xs[0L], xs[1L], output, costing));
            }
            else
            {
#line hidden
                {
#line 319 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    var (spareControls,ancillaOutput) = (Allocate.Apply((nQubits - 2L)), Allocate.Apply());
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line 320 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                        CompressControls.Apply((xs, spareControls, ancillaOutput, costing));
#line 321 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                        MicrosoftQuantumIntrinsicCNOT.Apply((ancillaOutput, output));
#line 322 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                        CompressControls.Adjoint.Apply((xs, spareControls, ancillaOutput, costing));
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
                        Release.Apply(spareControls);
#line hidden
                        Release.Apply(ancillaOutput);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Qubit,Boolean)), QVoid> ControlledBody => (__in__) =>
        {
            var (controls,(xs,output,costing)) = __in__;
#line 327 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            self.Apply((QArray<Qubit>.Add(controls, xs), output, costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,(IQArray<Qubit>,Qubit,Boolean)), QVoid> ControlledAdjointBody => (__in__) =>
        {
            var (controls,(xs,output,costing)) = __in__;
#line hidden
            self.Adjoint.Apply((QArray<Qubit>.Add(controls, xs), output, costing));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(IQArray<Qubit>,Qubit,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (xs,output,costing) = __in__;
#line hidden
            var nQubits = xs.Length;
#line hidden
            if ((nQubits == 1L))
            {
#line hidden
                MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((xs[0L], output));
            }
            else if ((nQubits == 2L))
            {
#line hidden
                ccnot.Adjoint.Apply((xs[0L], xs[1L], output, costing));
            }
            else
            {
#line hidden
                {
#line hidden
                    var (spareControls,ancillaOutput) = (Allocate.Apply((nQubits - 2L)), Allocate.Apply());
#line hidden
                    Exception __arg1__ = null;
                    try
                    {
#line hidden
                        CompressControls.Adjoint.Adjoint.Apply((xs, spareControls, ancillaOutput, costing));
#line hidden
                        MicrosoftQuantumIntrinsicCNOT.Adjoint.Apply((ancillaOutput, output));
#line hidden
                        CompressControls.Adjoint.Apply((xs, spareControls, ancillaOutput, costing));
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
                        Release.Apply(spareControls);
#line hidden
                        Release.Apply(ancillaOutput);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Intrinsic.Allocate));
            this.MicrosoftQuantumIntrinsicCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Intrinsic.CNOT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Intrinsic.Release));
            this.CompressControls = this.Factory.Get<IAdjointable<(IQArray<Qubit>,IQArray<Qubit>,Qubit,Boolean)>>(typeof(CompressControls));
            this.self = this;
            this.ccnot = this.Factory.Get<IAdjointable<(Qubit,Qubit,Qubit,Boolean)>>(typeof(ccnot));
        }

        public override IApplyData __dataIn((IQArray<Qubit>,Qubit,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> xs, Qubit output, Boolean costing)
        {
            return __m__.Run<TestIfAllOnes, (IQArray<Qubit>,Qubit,Boolean), QVoid>((xs, output, costing));
        }
    }

    public partial class CompareQubitstring : Adjointable<(Qubit,IQArray<Qubit>,IQArray<Boolean>,Boolean)>, ICallable
    {
        public CompareQubitstring(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Qubit,IQArray<Qubit>,IQArray<Boolean>,Boolean)>, IApplyData
        {
            public In((Qubit,IQArray<Qubit>,IQArray<Boolean>,Boolean) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
        }

        String ICallable.Name => "CompareQubitstring";
        String ICallable.FullName => "QUtilities.CompareQubitstring";
        protected ICallable Length
        {
            get;
            set;
        }

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

        protected IUnitary<(IQArray<Qubit>,Qubit,Boolean)> TestIfAllOnes
        {
            get;
            set;
        }

        public override Func<(Qubit,IQArray<Qubit>,IQArray<Boolean>,Boolean), QVoid> Body => (__in__) =>
        {
            var (success,qubitstring,target,costing) = __in__;
#line 337 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
            if ((target.Length == qubitstring.Length))
            {
#line 340 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                foreach (var i in new Range(0L, (target.Length - 1L)))
#line hidden
                {
#line 342 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    if ((target[i] == false))
                    {
#line 344 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                        MicrosoftQuantumIntrinsicX.Apply(qubitstring[i]);
                    }
                }

#line 349 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                TestIfAllOnes.Apply((qubitstring, success, costing));
#line 352 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                foreach (var i in new Range(0L, (target.Length - 1L)))
#line hidden
                {
#line 354 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                    if ((target[i] == false))
                    {
#line 356 "C:\\Users\\lizhenqiang\\Desktop\\copyaes - 副本\\aes\\QUtilities.qs"
                        MicrosoftQuantumIntrinsicX.Apply(qubitstring[i]);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(Qubit,IQArray<Qubit>,IQArray<Boolean>,Boolean), QVoid> AdjointBody => (__in__) =>
        {
            var (success,qubitstring,target,costing) = __in__;
#line hidden
            if ((target.Length == qubitstring.Length))
            {
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (target.Length - 1L))))
#line hidden
                {
#line hidden
                    if ((target[i] == false))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(qubitstring[i]);
                    }
                }

#line hidden
                TestIfAllOnes.Adjoint.Apply((qubitstring, success, costing));
#line hidden
                foreach (var i in RangeReverse.Apply(new Range(0L, (target.Length - 1L))))
#line hidden
                {
#line hidden
                    if ((target[i] == false))
                    {
#line hidden
                        MicrosoftQuantumIntrinsicX.Adjoint.Apply(qubitstring[i]);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Length = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Core.Length<>));
            this.RangeReverse = this.Factory.Get<ICallable<Range, Range>>(typeof(Microsoft.Quantum.Core.RangeReverse));
            this.MicrosoftQuantumIntrinsicX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Intrinsic.X));
            this.TestIfAllOnes = this.Factory.Get<IUnitary<(IQArray<Qubit>,Qubit,Boolean)>>(typeof(TestIfAllOnes));
        }

        public override IApplyData __dataIn((Qubit,IQArray<Qubit>,IQArray<Boolean>,Boolean) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit success, IQArray<Qubit> qubitstring, IQArray<Boolean> target, Boolean costing)
        {
            return __m__.Run<CompareQubitstring, (Qubit,IQArray<Qubit>,IQArray<Boolean>,Boolean), QVoid>((success, qubitstring, target, costing));
        }
    }
}