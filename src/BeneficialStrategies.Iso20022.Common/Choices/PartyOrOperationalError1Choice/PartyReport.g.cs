﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PartyReport.  ISO2002 ID# _kniH5O5NEeCisYr99QEiWA_-1882219329.
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
namespace BeneficialStrategies.Iso20022.Choices.PartyOrOperationalError1Choice
{
    /// <summary>
    /// Report information about party reference data.
    /// </summary>
    [IsoId("_kniH5O5NEeCisYr99QEiWA_-1882219329")]
    [DisplayName("Party Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PartyReport : PartyOrOperationalError1Choice_
    #else
    public partial class PartyReport : PartyOrOperationalError1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PartyReport instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PartyReport( SystemPartyIdentification3 reqPartyIdentification,PartyOrBusinessError1Choice_ reqPartyOrError )
        {
            PartyIdentification = reqPartyIdentification;
            PartyOrError = reqPartyOrError;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identification to unambiguously identify the party within the system.
        /// </summary>
        [IsoId("_knr44e5NEeCisYr99QEiWA_-521330042")]
        [DisplayName("Party Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PtyId")]
        #endif
        [IsoXmlTag("PtyId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required SystemPartyIdentification3 PartyIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required SystemPartyIdentification3 PartyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemPartyIdentification3 PartyIdentification { get; init; } 
        #else
        public SystemPartyIdentification3 PartyIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the returned party reference data or error information.
        /// </summary>
        [IsoId("_knr44u5NEeCisYr99QEiWA_1062655976")]
        [DisplayName("Party Or Error")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PtyOrErr")]
        #endif
        [IsoXmlTag("PtyOrErr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PartyOrBusinessError1Choice_ PartyOrError { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PartyOrBusinessError1Choice_ PartyOrError { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyOrBusinessError1Choice_ PartyOrError { get; init; } 
        #else
        public PartyOrBusinessError1Choice_ PartyOrError { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
