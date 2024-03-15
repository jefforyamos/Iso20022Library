﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for StatementUpdateTypeAsDSS.  ISO2002 ID# _sXPbwwaUEe2-DuDrUXkg2w.
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
namespace BeneficialStrategies.Iso20022.Choices.StatementUpdateTypeCodeAndDSSCode1Choice
{
    /// <summary>
    /// Update type expressed as a data source scheme and a code used within the data source scheme.
    /// </summary>
    [IsoId("_sXPbwwaUEe2-DuDrUXkg2w")]
    [DisplayName("Statement Update Type As DSS")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record StatementUpdateTypeAsDSS : StatementUpdateTypeCodeAndDSSCode1Choice_
    #else
    public partial class StatementUpdateTypeAsDSS : StatementUpdateTypeCodeAndDSSCode1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a StatementUpdateTypeAsDSS instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public StatementUpdateTypeAsDSS( System.String reqIssuer,System.String reqInformation )
        {
            Issuer = reqIssuer;
            Information = reqInformation;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_P_luVtp-Ed-ak6NoX_4Aeg_858746211")]
        [DisplayName("Issuer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Issr")]
        #endif
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max8Text)]
        [StringLength(maximumLength: 8 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax8Text Issuer { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Issuer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Issuer { get; init; } 
        #else
        public System.String Issuer { get; set; } 
        #endif
        
        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_P_luV9p-Ed-ak6NoX_4Aeg_858746099")]
        [DisplayName("Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Inf")]
        #endif
        [IsoXmlTag("Inf")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Information { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Information { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Information { get; init; } 
        #else
        public System.String Information { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
