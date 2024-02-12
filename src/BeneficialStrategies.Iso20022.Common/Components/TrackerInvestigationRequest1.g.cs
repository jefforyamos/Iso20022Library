﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TrackerInvestigationRequest1.  ISO2002 ID# _CWE9oWHGEe2dtcJPyL3-cw.
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
/// Provides detailed information on the investigation status as updated in the tracker or investigation facility.
/// </summary>
[IsoId("_CWE9oWHGEe2dtcJPyL3-cw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Tracker Investigation Request")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerInvestigationRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerInvestigationRequest1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerInvestigationRequest1( InvestigationType2Choice_ reqInvestigationType,TrackerInvestigationRequestStatus1 reqStatusAndAssignment )
    {
        InvestigationType = reqInvestigationType;
        StatusAndAssignment = reqStatusAndAssignment;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of investigation.
    /// </summary>
    [IsoId("_VDZMsHbgEe2_x8sH-8RFVw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Investigation Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestigationType2Choice_ InvestigationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public InvestigationType2Choice_ InvestigationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestigationType2Choice_ InvestigationType { get; init; } 
    #else
    public InvestigationType2Choice_ InvestigationType { get; set; } 
    #endif
    
    /// <summary>
    /// Request status and details of assignment by the tracking facility. 
    /// </summary>
    [IsoId("_-hxSgHbiEe2GR4CRzIB77g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Status And Assignment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TrackerInvestigationRequestStatus1 StatusAndAssignment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public TrackerInvestigationRequestStatus1 StatusAndAssignment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerInvestigationRequestStatus1 StatusAndAssignment { get; init; } 
    #else
    public TrackerInvestigationRequestStatus1 StatusAndAssignment { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the subject to which the investigation refers, for example a payment or statement entry.
    /// </summary>
    [IsoId("_RC5oUXfIEe2A6pitLvwC_g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Underlying")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingData1Choice_? Underlying { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingData1Choice_? Underlying { get; init; } 
    #else
    public UnderlyingData1Choice_? Underlying { get; set; } 
    #endif
    
    
    #nullable disable
    
}
