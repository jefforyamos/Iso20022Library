﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DTCLate1Code.  ISO2002 ID# _1rD7UDL3EeKU9IrkkToqcw_1757333975.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies late announcements.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1rD7UDL3EeKU9IrkkToqcw_1757333975")]
[Description(@"Specifies late announcements.")]
[DerivedFrom(typeof(DTCLateCode))]
public enum DTCLate1Code
{
    /// <summary>
    /// Informs both internal and external users that the announcement was added after the position capture date.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_1rD7UTL3EeKU9IrkkToqcw_-1281494311")]
    [Description(@"Informs both internal and external users that the announcement was added after the position capture date.")]
    LateAnnouncement = DTCLateCode.LateAnnouncement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Informs both internal and external users that the announcement is late, however, it has not gone through the position capture stage.
    /// Encoded/decoded by serializers as &quot;LAAS&quot;.
    /// </summary>
    [EnumMember(Value = "LAAS")]
    [IsoId("_1rD7UjL3EeKU9IrkkToqcw_-1916526157")]
    [Description(@"Informs both internal and external users that the announcement is late, however, it has not gone through the position capture stage.")]
    LateAnnouncementPending = DTCLateCode.LateAnnouncementPending, // same ordinal as derivation source for type conversions
    
}
