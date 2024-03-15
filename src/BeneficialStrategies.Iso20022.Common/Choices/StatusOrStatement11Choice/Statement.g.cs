﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Statement.  ISO2002 ID# _4yyB9SgSEeym1_Zp1BTvEw.
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
namespace BeneficialStrategies.Iso20022.Choices.StatusOrStatement11Choice
{
    /// <summary>
    /// Identifies the statement/report that was requested.
    /// </summary>
    [IsoId("_4yyB9SgSEeym1_Zp1BTvEw")]
    [DisplayName("Statement")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Statement : StatusOrStatement11Choice_
    #else
    public partial class Statement : StatusOrStatement11Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Statement instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Statement( DocumentNumber5Choice_ reqNumber )
        {
            Number = reqNumber;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Number used to identify a message or document.
        /// </summary>
        [IsoId("_9PiekUAlEeWE6OHCSJh8BQ")]
        [DisplayName("Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Nb")]
        #endif
        [IsoXmlTag("Nb")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required DocumentNumber5Choice_ Number { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required DocumentNumber5Choice_ Number { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DocumentNumber5Choice_ Number { get; init; } 
        #else
        public DocumentNumber5Choice_ Number { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
