﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SupplementaryData.  ISO2002 ID# _J-kCFYG-EeaalK9UbuVGFw.
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
namespace BeneficialStrategies.Iso20022.Choices.ReportingTransactionType1Choice
{
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_J-kCFYG-EeaalK9UbuVGFw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Supplementary Data")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SupplementaryData : ReportingTransactionType1Choice_
    #else
    public partial class SupplementaryData : ReportingTransactionType1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SupplementaryData instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SupplementaryData( SupplementaryDataEnvelope1 reqEnvelope )
        {
            Envelope = reqEnvelope;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance.
        /// In the case of XML, this is expressed by a valid XPath.
        /// </summary>
        [IsoId("_Qn988Np-Ed-ak6NoX_4Aeg_354388497")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Place And Name")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? PlaceAndName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? PlaceAndName { get; init; } 
        #else
        public System.String? PlaceAndName { get; set; } 
        #endif
        
        /// <summary>
        /// Technical element wrapping the supplementary data.
        /// </summary>
        [IsoId("_Qn988dp-Ed-ak6NoX_4Aeg_-642683856")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Envelope")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SupplementaryDataEnvelope1 Envelope { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public SupplementaryDataEnvelope1 Envelope { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SupplementaryDataEnvelope1 Envelope { get; init; } 
        #else
        public SupplementaryDataEnvelope1 Envelope { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
