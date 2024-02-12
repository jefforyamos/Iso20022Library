﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NonFinancialInstitutionSector10.  ISO2002 ID# _yfzO8Qz2Ee2YoLD-1vFj0g.
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
/// Provides detailed information concerning non financial counterparties.
/// </summary>
[IsoId("_yfzO8Qz2Ee2YoLD-1vFj0g")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Non Financial Institution Sector")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NonFinancialInstitutionSector10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Taxonomy for non-financial counterparties. The categories correspond to the main sections of NACE classification as defined in the regulation.
    /// </summary>
    [IsoId("_ygiOwQz2Ee2YoLD-1vFj0g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sector")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public GenericIdentification175? Sector { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _ygiOwQz2Ee2YoLD-1vFj0g
    
    /// <summary>
    /// Information whether the counterparty is above the clearing threshold.
    /// Usage: If the element is not present, the ClearingThreshold is False.
    /// </summary>
    [IsoId("_ygiOxQz2Ee2YoLD-1vFj0g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Clearing Threshold")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ClearingThreshold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClearingThreshold { get; init; } 
    #else
    public System.String? ClearingThreshold { get; set; } 
    #endif
    
    /// <summary>
    /// Directly linked to commercial activity or treasury financing: Information on whether the contract is objectively measurable as directly linked to the counterparty's commercial or treasury financing activity.
    /// Usage: If the element is not present, the DirectlyLinkedActivity is False.
    /// </summary>
    [IsoId("_ygiOxwz2Ee2YoLD-1vFj0g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Directly Linked Activity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? DirectlyLinkedActivity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DirectlyLinkedActivity { get; init; } 
    #else
    public System.String? DirectlyLinkedActivity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the counterparty is an entity established pursuant to federal law like for example a federal authority or a government corporation.
    /// Usage: If the element is not present, the FederalInstitution is False.
    /// </summary>
    [IsoId("_2Oz3UAz2Ee2YoLD-1vFj0g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Federal Institution")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? FederalInstitution { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FederalInstitution { get; init; } 
    #else
    public System.String? FederalInstitution { get; set; } 
    #endif
    
    
    #nullable disable
    
}
