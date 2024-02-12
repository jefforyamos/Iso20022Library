﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Member.  ISO2002 ID# _fSe1UdcZEeqRFcf2R4bPBw.
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
namespace BeneficialStrategies.Iso20022.Choices.MemberReportOrError8Choice
{
    /// <summary>
    /// Requested member data when found in the system.
    /// </summary>
    [IsoId("_fSe1UdcZEeqRFcf2R4bPBw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Member")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Member : MemberReportOrError8Choice_
    #else
    public partial class Member : MemberReportOrError8Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Word by which something is called or known or the family name of a person.
        /// </summary>
        [IsoId("_fUF-4dcZEeqRFcf2R4bPBw")]
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
        public IsoMax35Text? Name { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? Name { get; init; } 
        #else
        public System.String? Name { get; set; } 
        #endif
        
        /// <summary>
        /// Physical/logical address belonging to a member, segregated from its main address that is used for normal operations. The fund return address is used to route messages that require specific attention/exception handling, for example returns or rejects.
        /// </summary>
        [IsoId("_fUF-49cZEeqRFcf2R4bPBw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Return Address")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MemberIdentification3Choice_? ReturnAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MemberIdentification3Choice_? ReturnAddress { get; init; } 
        #else
        public MemberIdentification3Choice_? ReturnAddress { get; set; } 
        #endif
        
        /// <summary>
        /// Account to or from which a cash entry is made.
        /// </summary>
        [IsoId("_fUF-5dcZEeqRFcf2R4bPBw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Account")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CashAccount40? Account { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CashAccount40? Account { get; init; } 
        #else
        public CashAccount40? Account { get; set; } 
        #endif
        
        /// <summary>
        /// Nature of the relationship a member has with a system.
        /// </summary>
        [IsoId("_fUF-59cZEeqRFcf2R4bPBw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Type")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SystemMemberType1Choice_? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemMemberType1Choice_? Type { get; init; } 
        #else
        public SystemMemberType1Choice_? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Status of a member in a system, for example enabled or deleted.
        /// </summary>
        [IsoId("_fUF-6dcZEeqRFcf2R4bPBw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Status")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SystemMemberStatus1Choice_? Status { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SystemMemberStatus1Choice_? Status { get; init; } 
        #else
        public SystemMemberStatus1Choice_? Status { get; set; } 
        #endif
        
        /// <summary>
        /// Person to be contacted in a given organisation.
        /// </summary>
        [IsoId("_fUF-69cZEeqRFcf2R4bPBw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Contact Reference")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ContactIdentificationAndAddress2? ContactReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ContactIdentificationAndAddress2? ContactReference { get; init; } 
        #else
        public ContactIdentificationAndAddress2? ContactReference { get; set; } 
        #endif
        
        /// <summary>
        /// Number, or virtual address, used for communication.
        /// </summary>
        [IsoId("_fUF-7dcZEeqRFcf2R4bPBw")]
        #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        [DisplayName("Communication Address")]
        #endif
        #if DECLARE_DATACONTRACT
        [DataMember]
        #endif
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CommunicationAddress10? CommunicationAddress { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CommunicationAddress10? CommunicationAddress { get; init; } 
        #else
        public CommunicationAddress10? CommunicationAddress { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
