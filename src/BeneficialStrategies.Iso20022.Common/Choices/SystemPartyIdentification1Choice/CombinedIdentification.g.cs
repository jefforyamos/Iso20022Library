﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CombinedIdentification.  ISO2002 ID# _jBmr4O5NEeCisYr99QEiWA_-131070342.
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
namespace BeneficialStrategies.Iso20022.Choices.SystemPartyIdentification1Choice
{
    /// <summary>
    /// Identifies the party with the combined identification of both the responsible entity and the party itself.
    /// </summary>
    [IsoId("_jBmr4O5NEeCisYr99QEiWA_-131070342")]
    [DisplayName("Combined Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CombinedIdentification : SystemPartyIdentification1Choice_
    #else
    public partial class CombinedIdentification : SystemPartyIdentification1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CombinedIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CombinedIdentification( System.String reqRelatedPartyIdentification,System.String reqResponsiblePartyIdentification )
        {
            RelatedPartyIdentification = reqRelatedPartyIdentification;
            ResponsiblePartyIdentification = reqResponsiblePartyIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identification to unambiguously identify the party within the system.
        /// </summary>
        [IsoId("_knPM8-5NEeCisYr99QEiWA_-2106270244")]
        [DisplayName("Related Party Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RltdPtyId")]
        #endif
        [IsoXmlTag("RltdPtyId")]
        [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoBICFIIdentifier RelatedPartyIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String RelatedPartyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String RelatedPartyIdentification { get; init; } 
        #else
        public System.String RelatedPartyIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification of the party responsible for the maintenance of the party reference data.
        /// </summary>
        [IsoId("_knPM9O5NEeCisYr99QEiWA_1566757500")]
        [DisplayName("Responsible Party Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RspnsblPtyId")]
        #endif
        [IsoXmlTag("RspnsblPtyId")]
        [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoBICFIIdentifier ResponsiblePartyIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String ResponsiblePartyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String ResponsiblePartyIdentification { get; init; } 
        #else
        public System.String ResponsiblePartyIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
