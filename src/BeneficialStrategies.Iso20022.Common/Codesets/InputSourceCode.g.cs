﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for InputSourceCode.  ISO2002 ID# _XuZk8MmMEeWAGphE2LvqeA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the input source for the generation of the file.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XuZk8MmMEeWAGphE2LvqeA")]
[Description(@"Specifies the input source for the generation of the file.")]
[Derivations(typeof(InputSource1Code))]
public enum InputSourceCode
{
    /// <summary>
    /// File has been encoded.
    /// Encoded/decoded by serializers as &quot;NCOD&quot;.
    /// </summary>
    [EnumMember(Value = "NCOD")]
    [IsoId("_alnpsMmMEeWAGphE2LvqeA")]
    [Description(@"File has been encoded.")]
    Encoded,
    
    /// <summary>
    /// File has been uploaded through the CIS (Customer Identification System) system.
    /// Encoded/decoded by serializers as &quot;UCIS&quot;.
    /// </summary>
    [EnumMember(Value = "UCIS")]
    [IsoId("_dgGd0MmMEeWAGphE2LvqeA")]
    [Description(@"File has been uploaded through the CIS (Customer Identification System) system.")]
    UploadedViaCIS,
    
    /// <summary>
    /// File has been uploaded manually.
    /// Encoded/decoded by serializers as &quot;UMNL&quot;.
    /// </summary>
    [EnumMember(Value = "UMNL")]
    [IsoId("_iUrnIMmMEeWAGphE2LvqeA")]
    [Description(@"File has been uploaded manually.")]
    UploadedManually,
    
}
