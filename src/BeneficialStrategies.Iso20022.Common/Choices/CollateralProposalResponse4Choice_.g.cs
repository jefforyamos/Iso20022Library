﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CollateralProposalResponse4Choice.  ISO2002 ID# _vsq8gStIEeyOa655cLd-DQ.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Provides the collateral proposal response for the variation margin and the segregated independent amount, or the segregated independent amount only.
/// </summary>
[KnownType(typeof(CollateralProposalResponse4Choice.CollateralProposal))]
[KnownType(typeof(CollateralProposalResponse4Choice.SegregatedIndependentAmount))]
public abstract partial record CollateralProposalResponse4Choice_ : IIsoXmlSerilizable<CollateralProposalResponse4Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CollateralProposalResponse4Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "CollPrpsl" => CollateralProposalResponse4Choice.CollateralProposal.Deserialize(elementWithPayload),
             "SgrtdIndpdntAmt" => CollateralProposalResponse4Choice.SegregatedIndependentAmount.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CollateralProposalResponse4Choice choice.")
        };
    }
}
