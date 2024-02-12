﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Organisation.  ISO2002 ID# _52fY8UzQEea8fovz_9xSTQ.
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
namespace BeneficialStrategies.Iso20022.Choices.Party33Choice
{
    /// <summary>
    /// Organised structure that is set up for a particular purpose, for example, a business, government body, department, charity, or financial institution.
    /// </summary>
    [IsoId("_52fY8UzQEea8fovz_9xSTQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Organisation")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Organisation : Party33Choice_
    #else
    public partial class Organisation : Party33Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Name by which the organisation is known and which is usually used to identify that organisation.
        /// </summary>
        [IsoId("_BFL0QUzREea8fovz_9xSTQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Name")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax350Text? Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Name { get; init; } 
        #else
        public System.String? Name { get; set; } 
        #endif
        
        /// <summary>
        /// Name of the organisation in short form.
        /// </summary>
        [IsoId("_BFL0Q0zREea8fovz_9xSTQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Short Name")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? ShortName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ShortName { get; init; } 
        #else
        public System.String? ShortName { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identifier for the organisation.
        /// </summary>
        [IsoId("_BFL0RUzREea8fovz_9xSTQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Identification")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification72Choice_? Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification72Choice_? Identification { get; init; } 
        #else
        public PartyIdentification72Choice_? Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the organisation with a Legal Entity Identifier. This is a code allocated to a party as described in ISO 17442 "Financial Services - Legal Entity Identifier (LEI)".
        /// </summary>
        [IsoId("_BFL0R0zREea8fovz_9xSTQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Legal Entity Identifier")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoLEIIdentifier? LegalEntityIdentifier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? LegalEntityIdentifier { get; init; } 
        #else
        public System.String? LegalEntityIdentifier { get; set; } 
        #endif
        
        /// <summary>
        /// Purpose of the organisation, for example, charity.
        /// </summary>
        [IsoId("_BFL0SUzREea8fovz_9xSTQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Purpose")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Purpose { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Purpose { get; init; } 
        #else
        public System.String? Purpose { get; set; } 
        #endif
        
        /// <summary>
        /// Country in which the organisation is registered.
        /// </summary>
        [IsoId("_BFL0S0zREea8fovz_9xSTQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Registration Country")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CountryCode? RegistrationCountry { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? RegistrationCountry { get; init; } 
        #else
        public string? RegistrationCountry { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time at which a given organisation was officially registered.
        /// </summary>
        [IsoId("_BFL0TUzREea8fovz_9xSTQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Registration Date")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? RegistrationDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? RegistrationDate { get; init; } 
        #else
        public System.DateOnly? RegistrationDate { get; set; } 
        #endif
        
        /// <summary>
        /// Information related to an address to be inserted, updated or deleted.
        /// </summary>
        [IsoId("_BFL0T0zREea8fovz_9xSTQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Modified Postal Address")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ModificationScope34? ModifiedPostalAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ModificationScope34? ModifiedPostalAddress { get; init; } 
        #else
        public ModificationScope34? ModifiedPostalAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Type of organisation.
        /// </summary>
        [IsoId("_BFL0UUzREea8fovz_9xSTQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Type Of Organisation")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public OrganisationType1Choice_? TypeOfOrganisation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrganisationType1Choice_? TypeOfOrganisation { get; init; } 
        #else
        public OrganisationType1Choice_? TypeOfOrganisation { get; set; } 
        #endif
        
        /// <summary>
        /// Place of listing for shares in the organisation.
        /// </summary>
        [IsoId("_Up6j4UzsEea8fovz_9xSTQ")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Place Of Listing")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMICIdentifier? PlaceOfListing { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? PlaceOfListing { get; init; } 
        #else
        public System.String? PlaceOfListing { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
