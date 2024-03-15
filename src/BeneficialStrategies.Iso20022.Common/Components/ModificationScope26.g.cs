﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ModificationScope26.  ISO2002 ID# _L_D6ISCBEeWhHbfCMWc1cw.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Scope of the modification to be applied on an identified set of information.
/// </summary>
[IsoId("_L_D6ISCBEeWhHbfCMWc1cw")]
[DisplayName("Modification Scope")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ModificationScope26
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ModificationScope26 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ModificationScope26( DataModification1Code reqModificationScopeIndication,Intermediary36 reqIntermediary )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
        Intermediary = reqIntermediary;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of modification to be applied.
    /// </summary>
    [IsoId("_Ma9zASCBEeWhHbfCMWc1cw")]
    [DisplayName("Modification Scope Indication")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ModScpIndctn")]
    #endif
    [IsoXmlTag("ModScpIndctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataModification1Code ModificationScopeIndication { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataModification1Code ModificationScopeIndication { get; init; } 
    #else
    public DataModification1Code ModificationScopeIndication { get; set; } 
    #endif
    
    /// <summary>
    /// Intermediary or other party related to the management of the account. In some markets, when this intermediary is a party acting on behalf of the investor for which it has opened an account at, for example, a central securities depository or international central securities depository, this party is known by the investor as the &apos;account controller&apos;.
    /// </summary>
    [IsoId("_Ma9zAyCBEeWhHbfCMWc1cw")]
    [DisplayName("Intermediary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Intrmy")]
    #endif
    [IsoXmlTag("Intrmy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Intermediary36 Intermediary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Intermediary36 Intermediary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Intermediary36 Intermediary { get; init; } 
    #else
    public Intermediary36 Intermediary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
