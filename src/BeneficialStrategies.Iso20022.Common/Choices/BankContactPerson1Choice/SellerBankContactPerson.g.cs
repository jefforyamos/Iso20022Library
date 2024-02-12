﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SellerBankContactPerson.  ISO2002 ID# _pb7W8DAZEeOKib24wnHaFg.
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
namespace BeneficialStrategies.Iso20022.Choices.BankContactPerson1Choice
{
    /// <summary>
    /// Person to be contacted in the seller's bank.
    /// </summary>
    [IsoId("_pb7W8DAZEeOKib24wnHaFg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Seller Bank Contact Person")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SellerBankContactPerson : BankContactPerson1Choice_
    #else
    public partial class SellerBankContactPerson : BankContactPerson1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SellerBankContactPerson instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SellerBankContactPerson( System.String reqName )
        {
            Name = reqName;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_QBOtFNp-Ed-ak6NoX_4Aeg_-1134631327")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Name")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax35Text Name { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public System.String Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String Name { get; init; } 
        #else
        public System.String Name { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies the terms used to formally address a person.
        /// </summary>
        [IsoId("_QBOtFdp-Ed-ak6NoX_4Aeg_-1825403256")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Name Prefix")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public NamePrefix1Code? NamePrefix { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public NamePrefix1Code? NamePrefix { get; init; } 
        #else
        public NamePrefix1Code? NamePrefix { get; set; } 
        #endif
        
        /// <summary>
        /// First name of a person.
        /// </summary>
        [IsoId("_QBOtFtp-Ed-ak6NoX_4Aeg_-1028894727")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Given Name")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? GivenName { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? GivenName { get; init; } 
        #else
        public System.String? GivenName { get; set; } 
        #endif
        
        /// <summary>
        /// Role of the party in the activity.
        /// </summary>
        [IsoId("_QBOtF9p-Ed-ak6NoX_4Aeg_2125093183")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Role")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? Role { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Role { get; init; } 
        #else
        public System.String? Role { get; set; } 
        #endif
        
        /// <summary>
        /// Collection of information that identifies a phone number, as defined by telecom services.
        /// </summary>
        [IsoId("_QBOtGNp-Ed-ak6NoX_4Aeg_-505408090")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Phone Number")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 0 ,MinimumLength = 0)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoPhoneNumber? PhoneNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? PhoneNumber { get; init; } 
        #else
        public System.String? PhoneNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Collection of information that identifies a FAX number, as defined by telecom services.
        /// </summary>
        [IsoId("_QBOtGdp-Ed-ak6NoX_4Aeg_-505408635")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Fax Number")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 0 ,MinimumLength = 0)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoPhoneNumber? FaxNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? FaxNumber { get; init; } 
        #else
        public System.String? FaxNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_QBX3ANp-Ed-ak6NoX_4Aeg_-505409021")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Email Address")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [StringLength(maximumLength: 256 ,MinimumLength = 1)]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax256Text? EmailAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? EmailAddress { get; init; } 
        #else
        public System.String? EmailAddress { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
