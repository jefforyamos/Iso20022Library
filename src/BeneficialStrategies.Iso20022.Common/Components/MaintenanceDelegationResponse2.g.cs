﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MaintenanceDelegationResponse2.  ISO2002 ID# _OZ8TsY4HEeWrZqsymMFdfg.
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
/// Information related to the request of maintenance delegations.
/// </summary>
[IsoId("_OZ8TsY4HEeWrZqsymMFdfg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Maintenance Delegation Response")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MaintenanceDelegationResponse2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MaintenanceDelegationResponse2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MaintenanceDelegationResponse2( GenericIdentification72 reqTMIdentification )
    {
        TMIdentification = reqTMIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    [IsoId("_Okq9AY4HEeWrZqsymMFdfg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("TM Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification72 TMIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public GenericIdentification72 TMIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification72 TMIdentification { get; init; } 
    #else
    public GenericIdentification72 TMIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    [IsoId("_Okq9A44HEeWrZqsymMFdfg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Master TM Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification72? MasterTMIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification72? MasterTMIdentification { get; init; } 
    #else
    public GenericIdentification72? MasterTMIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    [IsoId("_Okq9BY4HEeWrZqsymMFdfg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Delegation Response")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public MaintenanceDelegation4? DelegationResponse { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _Okq9BY4HEeWrZqsymMFdfg
    
    
    #nullable disable
    
}
