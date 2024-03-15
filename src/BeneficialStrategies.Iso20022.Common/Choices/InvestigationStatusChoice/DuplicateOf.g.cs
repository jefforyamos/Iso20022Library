﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DuplicateOf.  ISO2002 ID# _UuYYttp-Ed-ak6NoX_4Aeg_-1595640510.
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
namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatusChoice
{
    /// <summary>
    /// Identifies a duplicated case. When present, the case identified in the message must be closed. The case identified as duplicated (in this component) will be pursued.
    /// </summary>
    [IsoId("_UuYYttp-Ed-ak6NoX_4Aeg_-1595640510")]
    [DisplayName("Duplicate Of")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record DuplicateOf : InvestigationStatusChoice_
    #else
    public partial class DuplicateOf : InvestigationStatusChoice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a DuplicateOf instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public DuplicateOf( System.String reqIdentification,System.String reqCreator )
        {
            Identification = reqIdentification;
            Creator = reqCreator;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique id assigned by the case creator.
        /// </summary>
        [IsoId("_SpAno9p-Ed-ak6NoX_4Aeg_136183942")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Identification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Identification { get; init; } 
        #else
        public System.String Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Party that created the case.
        /// </summary>
        [IsoId("_SpAnpNp-Ed-ak6NoX_4Aeg_136184310")]
        [DisplayName("Creator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Cretr")]
        #endif
        [IsoXmlTag("Cretr")]
        [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoAnyBICIdentifier Creator { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String Creator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Creator { get; init; } 
        #else
        public System.String Creator { get; set; } 
        #endif
        
        /// <summary>
        /// Set to yes if the case was closed and needs to be re-opened.
        /// </summary>
        [IsoId("_SpAnpdp-Ed-ak6NoX_4Aeg_-1913695135")]
        [DisplayName("Reopen Case Indication")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ReopCaseIndctn")]
        #endif
        [IsoXmlTag("ReopCaseIndctn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? ReopenCaseIndication { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ReopenCaseIndication { get; init; } 
        #else
        public System.String? ReopenCaseIndication { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
