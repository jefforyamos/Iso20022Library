﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Attendance2.  ISO2002 ID# _eX9h8fNhEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information and conditions provided for the physical attendance to the meeting.  
/// </summary>
[IsoId("_eX9h8fNhEeqRfth943bvEA")]
[DisplayName("Attendance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Attendance2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Conditions for physical admittance to the general meeting.
    /// </summary>
    [IsoId("_eylocfNhEeqRfth943bvEA")]
    [DisplayName("Admission Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdmssnConds")]
    #endif
    [IsoXmlTag("AdmssnConds")]
    [MinLength(0)]
    [MaxLength(7)]
    public ValueList<AttendanceAdmissionConditions2> AdmissionConditions { get; init; } = new ValueList<AttendanceAdmissionConditions2>(){};
    
    /// <summary>
    /// Specifies how to order the attendance card or to give notice of attendance.
    /// </summary>
    [IsoId("_eyloc_NhEeqRfth943bvEA")]
    [DisplayName("Confirmation Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfInf")]
    #endif
    [IsoXmlTag("ConfInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? ConfirmationInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConfirmationInformation { get; init; } 
    #else
    public System.String? ConfirmationInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the beneficial owner or agent must provide notification of its intention to participate in the meeting. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_eylodfNhEeqRfth943bvEA")]
    [DisplayName("Confirmation Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfDdln")]
    #endif
    [IsoXmlTag("ConfDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? ConfirmationDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? ConfirmationDeadline { get; init; } 
    #else
    public DateFormat58Choice_? ConfirmationDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time by which the attendance to the meeting should be confirmed. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_eylod_NhEeqRfth943bvEA")]
    [DisplayName("Confirmation Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfMktDdln")]
    #endif
    [IsoXmlTag("ConfMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat58Choice_? ConfirmationMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat58Choice_? ConfirmationMarketDeadline { get; init; } 
    #else
    public DateFormat58Choice_? ConfirmationMarketDeadline { get; set; } 
    #endif
    
    
    #nullable disable
    
}
