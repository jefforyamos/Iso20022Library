﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NameAndAddress.  ISO2002 ID# _QQa_odp-Ed-ak6NoX_4Aeg_-395733973.
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
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification1Choice
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QQa_odp-Ed-ak6NoX_4Aeg_-395733973")]
    [DisplayName("Name And Address")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record NameAndAddress : PartyIdentification1Choice_
    #else
    public partial class NameAndAddress : PartyIdentification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a NameAndAddress instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public NameAndAddress( System.String reqName )
        {
            Name = reqName;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_PZcUV9p-Ed-ak6NoX_4Aeg_-618689920")]
        [DisplayName("Name")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nm")]
        #endif
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Name { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Name { get; init; } 
        #else
        public System.String Name { get; set; } 
        #endif
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_PZcUWNp-Ed-ak6NoX_4Aeg_-331477617")]
        [DisplayName("Address")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Adr")]
        #endif
        [IsoXmlTag("Adr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public LongPostalAddress1Choice_? Address { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public LongPostalAddress1Choice_? Address { get; init; } 
        #else
        public LongPostalAddress1Choice_? Address { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
