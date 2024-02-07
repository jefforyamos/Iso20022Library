﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CollateralPortfolioCode5Choice.  ISO2002 ID# _YwE-cTIDEe2fXedS_ucFOA.
//

using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices;

/// <summary>
/// Specifies the unique codes identifying the portfolio.
/// </summary>
[KnownType(typeof(CollateralPortfolioCode5Choice.Portfolio))]
[KnownType(typeof(CollateralPortfolioCode5Choice.MarginPortfolioCode))]
public abstract partial record CollateralPortfolioCode5Choice_ : IIsoXmlSerilizable<CollateralPortfolioCode5Choice_>
{
    /// <summary>
    /// Serialize the state of this record per ISO 20022 specifications.
    /// Abstract here, overridden in each of the concrete choices.
    /// </summary>
    public abstract void Serialize(XmlWriter writer, string xmlNamespace);
    
    /// <summary>
    /// After detecting the choice being deserialized, defers the serialization of the element to the appropriate concrete choice record.
    /// </summary>
    public static CollateralPortfolioCode5Choice_ Deserialize(XElement element)
    {
        var elementWithPayload = element;
        return elementWithPayload.Name.LocalName switch
        {
             "Prtfl" => CollateralPortfolioCode5Choice.Portfolio.Deserialize(elementWithPayload),
             "MrgnPrtflCd" => CollateralPortfolioCode5Choice.MarginPortfolioCode.Deserialize(elementWithPayload),
            _ => throw new InvalidOperationException($@"Xml tag '{elementWithPayload.Name.LocalName}' does not correspond to a valid CollateralPortfolioCode5Choice choice.")
        };
    }
}
