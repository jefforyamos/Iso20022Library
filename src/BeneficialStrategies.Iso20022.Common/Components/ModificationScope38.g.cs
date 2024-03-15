﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ModificationScope38.  ISO2002 ID# _2eQ2UYmAEea2EL0wKRDnMQ.
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
[IsoId("_2eQ2UYmAEea2EL0wKRDnMQ")]
[DisplayName("Modification Scope")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ModificationScope38
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ModificationScope38 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ModificationScope38( DataModification1Code reqModificationScopeIndication,Intermediary36 reqIntermediary )
    {
        ModificationScopeIndication = reqModificationScopeIndication;
        Intermediary = reqIntermediary;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of modification to be applied.
    /// </summary>
    [IsoId("_3DAiIYmAEea2EL0wKRDnMQ")]
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
    /// Intermediary or other party related to the management of the account.
    /// </summary>
    [IsoId("_3DAiI4mAEea2EL0wKRDnMQ")]
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
