﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MarginPortfolio3.  ISO2002 ID# _tm21gTICEe2fXedS_ucFOA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the unique codes.
/// </summary>
public partial record MarginPortfolio3
     : IIsoXmlSerilizable<MarginPortfolio3>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// Usage:
    /// NoCode is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    public required PortfolioCode5Choice_ InitialMarginPortfolioCode { get; init; } 
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// Usage:
    /// NoCode is reported if the collateralisation was performed on a transaction level basis, or if there is no collateral agreement or if no collateral is posted or received.
    /// </summary>
    public PortfolioCode5Choice_? VariationMarginPortfolioCode { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "InitlMrgnPrtflCd", xmlNamespace );
        InitialMarginPortfolioCode.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (VariationMarginPortfolioCode is PortfolioCode5Choice_ VariationMarginPortfolioCodeValue)
        {
            writer.WriteStartElement(null, "VartnMrgnPrtflCd", xmlNamespace );
            VariationMarginPortfolioCodeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MarginPortfolio3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
