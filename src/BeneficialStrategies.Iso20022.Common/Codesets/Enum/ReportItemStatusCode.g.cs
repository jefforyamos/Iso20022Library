﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ReportItemStatusCode.  ISO2002 ID# _sjRYp0irEeSlHoYg_EudVQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an entry in a report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sjRYp0irEeSlHoYg_EudVQ")]
[Description(@"Specifies the status of an entry in a report.")]
[Derivations(typeof(ReportItemStatus1Code))]
public enum ReportItemStatusCode
{
    /// <summary>
    /// Entry has been accepted with exceptions by the receiver of the report.
    /// Encoded/decoded by serializers as "ACWE".
    /// </summary>
    [EnumMember(Value = "ACWE")]
    [IsoId("_sjRYqkirEeSlHoYg_EudVQ")]
    [Description(@"Entry has been accepted with exceptions by the receiver of the report.")]
    AcceptedWithException,
    
    /// <summary>
    /// Entry has been rejected by the receiver of the report.
    /// Encoded/decoded by serializers as "REJT".
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_sjRYqEirEeSlHoYg_EudVQ")]
    [Description(@"Entry has been rejected by the receiver of the report.")]
    Rejected,
    
    /// <summary>
    /// Entry has been accepted by the receiver of the report.
    /// Encoded/decoded by serializers as "ACPD".
    /// </summary>
    [EnumMember(Value = "ACPD")]
    [IsoId("_Ff6cYUisEeSlHoYg_EudVQ")]
    [Description(@"Entry has been accepted by the receiver of the report.")]
    Accepted,
    
}
