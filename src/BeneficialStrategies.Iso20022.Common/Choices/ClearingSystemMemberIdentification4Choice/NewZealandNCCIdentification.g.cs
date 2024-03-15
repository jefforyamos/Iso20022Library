﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NewZealandNCCIdentification.  ISO2002 ID# _VwSCY7NIEeejueAciesPMA.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice
{
    /// <summary>
    /// New Zealand Bank/Branch Code - identifies New Zealand institutions on the New Zealand national clearing system. The code is assigned by the New Zealand Bankers&apos; Association (NZBA).
    /// </summary>
    [IsoId("_VwSCY7NIEeejueAciesPMA")]
    [DisplayName("New Zealand NCC Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NewZealandNCCIdentification : ClearingSystemMemberIdentification4Choice_
    #else
    public partial class NewZealandNCCIdentification : ClearingSystemMemberIdentification4Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NewZealandNCCIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NewZealandNCCIdentification( System.String reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// New Zealand Bank/Branch Code. Identifies New Zealand institutions on the New Zealand national clearing system. The code is assigned by the New Zealand Bankers&apos; Association (NZBA).
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NZNCC")]
        #endif
        [IsoXmlTag("NZNCC")]
        [IsoSimpleType(IsoSimpleType.NewZealandNCCIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoNewZealandNCCIdentifier Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Value { get; init; } 
        #else
        public System.String Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
