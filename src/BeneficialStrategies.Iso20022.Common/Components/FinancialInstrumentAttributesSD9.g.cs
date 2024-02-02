﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentAttributesSD9.  ISO2002 ID# _Vboa0noCEeO2o_OAyvnbZw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding underlying security details.
/// </summary>
[DataContract]
[XmlType]
public partial record FinancialInstrumentAttributesSD9
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [DataMember]
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Represents the 'original' security identifier of the event. It is used in the scenarios like "partial call" where there are 2 events. The first event distributes into the Contra CUSIP, a temporary security; and on the second event that temporary security becomes the underlying security of the event. This element is used in the second event to point to the original CUSIP.
    /// </summary>
    [DataMember]
    public OtherIdentification2? OriginatingSecurityIdentification { get; init; } 
    
    #nullable disable
}
