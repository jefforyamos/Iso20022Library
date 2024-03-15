﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCProtectInstructionStatus1Code.  ISO2002 ID# _Cq2tgJIdEeaNbfbSYshZYw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// DTC (The Depository Trust Company) system status code of protect instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Cq2tgJIdEeaNbfbSYshZYw")]
[Description(@"DTC (The Depository Trust Company) system status code of protect instruction.")]
[DerivedFrom(typeof(DTCInstructionStatusCode))]
public enum DTCProtectInstructionStatus1Code
{
    /// <summary>
    /// Instruction pending release or delete from approval function.
    /// Encoded/decoded by serializers as &quot;PENA&quot;.
    /// </summary>
    [EnumMember(Value = "PENA")]
    [IsoId("_MS-eUZIdEeaNbfbSYshZYw")]
    [Description(@"Instruction pending release or delete from approval function.")]
    PendingApproval = DTCInstructionStatusCode.PendingApproval, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Client instruction withdrawn for events with withdrawal privilege.
    /// Encoded/decoded by serializers as &quot;WITH&quot;.
    /// </summary>
    [EnumMember(Value = "WITH")]
    [IsoId("_McjREZIdEeaNbfbSYshZYw")]
    [Description(@"Client instruction withdrawn for events with withdrawal privilege.")]
    Withdrawn = DTCInstructionStatusCode.Withdrawn, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect instruction has been fully covered.
    /// Encoded/decoded by serializers as &quot;COVR&quot;.
    /// </summary>
    [EnumMember(Value = "COVR")]
    [IsoId("_MoTOEZIdEeaNbfbSYshZYw")]
    [Description(@"Protect instruction has been fully covered.")]
    FullyCovered = DTCInstructionStatusCode.FullyCovered, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect instruction has expired.
    /// Encoded/decoded by serializers as &quot;EXPI&quot;.
    /// </summary>
    [EnumMember(Value = "EXPI")]
    [IsoId("_NdphsZIdEeaNbfbSYshZYw")]
    [Description(@"Protect instruction has expired.")]
    Expired = DTCInstructionStatusCode.Expired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Protect instruction which has not been fully covered. Will include partial covers.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_N2nbUZIdEeaNbfbSYshZYw")]
    [Description(@"Protect instruction which has not been fully covered. Will include partial covers.")]
    Open = DTCInstructionStatusCode.Open, // same ordinal as derivation source for type conversions
    
}
