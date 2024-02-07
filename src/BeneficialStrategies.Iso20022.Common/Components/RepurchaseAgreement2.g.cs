﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RepurchaseAgreement2.  ISO2002 ID# _onOhMbJVEeaYqc4G3TTwhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Agreement between two parties to sell a financial instrument or set of financial instruments and repurchase at an agreed later date.
/// </summary>
public partial record RepurchaseAgreement2
     : IIsoXmlSerilizable<RepurchaseAgreement2>
{
    #nullable enable
    
    /// <summary>
    /// Date on which the repurchase agreement matures.
    /// </summary>
    public required IsoISODate MaturityDate { get; init; } 
    /// <summary>
    /// Specifies the repurchase price at maturity of the repo.
    /// </summary>
    public required IsoActiveCurrencyAndAmount SecondLegPrice { get; init; } 
    /// <summary>
    /// Specifies the dirty price of the underlying security or securities in repo.
    /// </summary>
    public required IsoActiveCurrencyAndAmount CollateralMarketValue { get; init; } 
    /// <summary>
    /// Identifies the counterparty to the repurchase agreement.
    /// </summary>
    public required IsoLEIIdentifier Counterparty { get; init; } 
    /// <summary>
    /// Specifies the type of repurchase agreement.
    /// </summary>
    public required RepurchaseAgreementType3Choice_ RepurchaseAgreementType { get; init; } 
    /// <summary>
    /// Identifies the triparty repurchase agent.
    /// </summary>
    public IsoLEIIdentifier? TripartyAgentIdentification { get; init; } 
    
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
        writer.WriteStartElement(null, "MtrtyDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(MaturityDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ScndLegPric", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(SecondLegPrice)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CollMktVal", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(CollateralMarketValue)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CtrPty", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(Counterparty)); // data type LEIIdentifier System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "RpAgrmtTp", xmlNamespace );
        RepurchaseAgreementType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TripartyAgentIdentification is IsoLEIIdentifier TripartyAgentIdentificationValue)
        {
            writer.WriteStartElement(null, "TrptyAgtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoLEIIdentifier(TripartyAgentIdentificationValue)); // data type LEIIdentifier System.String
            writer.WriteEndElement();
        }
    }
    public static RepurchaseAgreement2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
