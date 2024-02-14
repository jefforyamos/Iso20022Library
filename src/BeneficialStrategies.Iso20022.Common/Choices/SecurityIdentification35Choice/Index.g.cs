﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Index.  ISO2002 ID# _ZmtSVQ1HEeqV4s5SpzR1dQ.
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
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification35Choice
{
    /// <summary>
    /// Index name where the underlying is an index.
    /// </summary>
    [IsoId("_ZmtSVQ1HEeqV4s5SpzR1dQ")]
    [DisplayName("Index")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Index : SecurityIdentification35Choice_
    #else
    public partial class Index : SecurityIdentification35Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Index instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Index( BenchmarkCurveName3Code reqValue )
        {
            Value = reqValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a benchmark curve name.
        /// </summary>
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Indx")]
        #endif
        [IsoXmlTag("Indx")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required BenchmarkCurveName3Code Value { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required BenchmarkCurveName3Code Value { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public BenchmarkCurveName3Code Value { get; init; } 
        #else
        public BenchmarkCurveName3Code Value { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
