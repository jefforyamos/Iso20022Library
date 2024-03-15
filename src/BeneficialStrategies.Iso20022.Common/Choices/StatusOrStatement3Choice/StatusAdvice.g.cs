﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StatusAdvice.  ISO2002 ID# _CEn-0fJlEd-DocZblYEqZw.
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
namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement3Choice
{
    /// <summary>
    /// Identify the status advice and the transaction for which the status advice was requested.
    /// </summary>
    [IsoId("_CEn-0fJlEd-DocZblYEqZw")]
    [DisplayName("Status Advice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record StatusAdvice : StatusOrStatement3Choice_
    #else
    public partial class StatusAdvice : StatusOrStatement3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a StatusAdvice instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public StatusAdvice( DocumentNumber1Choice_ reqNumber )
        {
            Number = reqNumber;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_D2Ul8_JlEd-DocZblYEqZw")]
        [DisplayName("Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nb")]
        #endif
        [IsoXmlTag("Nb")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DocumentNumber1Choice_ Number { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DocumentNumber1Choice_ Number { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DocumentNumber1Choice_ Number { get; init; } 
        #else
        public DocumentNumber1Choice_ Number { get; set; } 
        #endif
        
        /// <summary>
        /// References of transaction for which the status is requested.
        /// </summary>
        [IsoId("_D2Ul9fJlEd-DocZblYEqZw")]
        [DisplayName("References")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Refs")]
        #endif
        [IsoXmlTag("Refs")]
        public ValueList<Identification7> References { get; init; } = new ValueList<Identification7>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _D2Ul9fJlEd-DocZblYEqZw
        
        
        #nullable disable
        
    }
}
