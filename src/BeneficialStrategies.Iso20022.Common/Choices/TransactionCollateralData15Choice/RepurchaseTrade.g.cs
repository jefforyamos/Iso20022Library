﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RepurchaseTrade.  ISO2002 ID# _fMZ5wQAFEeqefbt-QjTNnA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.TransactionCollateralData15Choice;

/// <summary>
/// Data on collateral used for the repurchase trade transaction.
/// </summary>
public partial record RepurchaseTrade : TransactionCollateralData15Choice_
     , IIsoXmlSerilizable<RepurchaseTrade>
{
    #nullable enable
    
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of cash, securities, or commodities versus collateral for the opening leg (spot leg) of the transaction.
    /// </summary>
    public IsoISODate? CollateralValueDate { get; init; } 
    /// <summary>
    /// Indication of the type of collateral component.
    /// </summary>
    public CollateralType16? AssetType { get; init; } 
    /// <summary>
    /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
    /// </summary>
    public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; } 
    /// <summary>
    /// Identification of the collateral basket.
    /// </summary>
    public SecurityIdentification26Choice_? BasketIdentifier { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (CollateralValueDate is IsoISODate CollateralValueDateValue)
        {
            writer.WriteStartElement(null, "CollValDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(CollateralValueDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (AssetType is CollateralType16 AssetTypeValue)
        {
            writer.WriteStartElement(null, "AsstTp", xmlNamespace );
            AssetTypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (NetExposureCollateralisationIndicator is IsoTrueFalseIndicator NetExposureCollateralisationIndicatorValue)
        {
            writer.WriteStartElement(null, "NetXpsrCollstnInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(NetExposureCollateralisationIndicatorValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (BasketIdentifier is SecurityIdentification26Choice_ BasketIdentifierValue)
        {
            writer.WriteStartElement(null, "BsktIdr", xmlNamespace );
            BasketIdentifierValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new RepurchaseTrade Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
