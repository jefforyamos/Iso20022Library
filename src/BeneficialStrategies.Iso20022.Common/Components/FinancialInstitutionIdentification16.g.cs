﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstitutionIdentification16.  ISO2002 ID# _U3JqwVOVEeijdq8ilaxyOA.
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
/// Identification of a financial institution.
/// </summary>
[IsoId("_U3JqwVOVEeijdq8ilaxyOA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Financial Institution Identification")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstitutionIdentification16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the financial institution expressed as a BIC.
    /// </summary>
    [IsoId("_nvIdZVOVEeijdq8ilaxyOA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("BICFI")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBICFIDec2014Identifier? BICFI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BICFI { get; init; } 
    #else
    public System.String? BICFI { get; set; } 
    #endif
    
    /// <summary>
    /// Information used to identify a member within a clearing system.
    /// </summary>
    [IsoId("_nvIdZlOVEeijdq8ilaxyOA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Clearing System Member Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClearingSystemMemberIdentification4Choice_? ClearingSystemMemberIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClearingSystemMemberIdentification4Choice_? ClearingSystemMemberIdentification { get; init; } 
    #else
    public ClearingSystemMemberIdentification4Choice_? ClearingSystemMemberIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_vThb4VOVEeijdq8ilaxyOA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Name And Address")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress5? NameAndAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress5? NameAndAddress { get; init; } 
    #else
    public NameAndAddress5? NameAndAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    [IsoId("_VHX4E1OVEeijdq8ilaxyOA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("LEI")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoLEIIdentifier? LEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LEI { get; init; } 
    #else
    public System.String? LEI { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier, as assigned to a financial institution using a proprietary identification scheme.
    /// </summary>
    [IsoId("_CZuQsVOWEeijdq8ilaxyOA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Proprietary Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProprietaryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProprietaryIdentification { get; init; } 
    #else
    public System.String? ProprietaryIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a specific branch of the financial institution.
    /// </summary>
    [IsoId("_P36UIFOWEeijdq8ilaxyOA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Branch Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchData2? BranchIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchData2? BranchIdentification { get; init; } 
    #else
    public BranchData2? BranchIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
