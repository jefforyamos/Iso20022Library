﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNarrative10.  ISO2002 ID# _ULXLNNp-Ed-ak6NoX_4Aeg_-1951841609.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the information conditions.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionNarrative10
{
    #nullable enable
    
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax350Text> AdditionalText { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax350Text> PartyContactNarrative { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
