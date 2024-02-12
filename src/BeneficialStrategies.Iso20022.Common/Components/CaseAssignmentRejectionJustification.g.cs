﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CaseAssignmentRejectionJustification.  ISO2002 ID# _VJDig9p-Ed-ak6NoX_4Aeg_-1410536131.
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
/// Provides the reason for rejecting the case assignment.
/// </summary>
[IsoId("_VJDig9p-Ed-ak6NoX_4Aeg_-1410536131")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Case Assignment Rejection Justification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CaseAssignmentRejectionJustification
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CaseAssignmentRejectionJustification instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CaseAssignmentRejectionJustification( CaseAssignmentRejection1Code reqRejectionReason )
    {
        RejectionReason = reqRejectionReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for the rejection of a case assignment, in a coded form.
    /// </summary>
    [IsoId("_VJDihNp-Ed-ak6NoX_4Aeg_-1371748328")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rejection Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CaseAssignmentRejection1Code RejectionReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CaseAssignmentRejection1Code RejectionReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CaseAssignmentRejection1Code RejectionReason { get; init; } 
    #else
    public CaseAssignmentRejection1Code RejectionReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
