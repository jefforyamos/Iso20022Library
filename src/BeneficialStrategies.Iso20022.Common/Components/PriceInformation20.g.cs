﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PriceInformation20.  ISO2002 ID# _-MUIYdLGEeiN28wlpBQScw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
public partial record PriceInformation20
     : IIsoXmlSerilizable<PriceInformation20>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of price and information about the price.
    /// </summary>
    public required TypeOfPrice28Choice_ Type { get; init; } 
    /// <summary>
    /// Value of the price, for example, as a currency and value.
    /// </summary>
    public required PriceRateOrAmountOrUnknown2Choice_ Value { get; init; } 
    /// <summary>
    /// Type of value in which the price is expressed.
    /// </summary>
    public required YieldedOrValueType1Choice_ ValueType { get; init; } 
    /// <summary>
    /// Place from which the price was obtained.
    /// </summary>
    public MarketIdentification89? SourceOfPrice { get; init; } 
    /// <summary>
    /// Date on which the price is obtained. With an investment fund, this is as stated in the prospectus.
    /// </summary>
    public DateAndDateTime2Choice_? QuotationDate { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        Type.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Val", xmlNamespace );
        Value.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "ValTp", xmlNamespace );
        ValueType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SourceOfPrice is MarketIdentification89 SourceOfPriceValue)
        {
            writer.WriteStartElement(null, "SrcOfPric", xmlNamespace );
            SourceOfPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (QuotationDate is DateAndDateTime2Choice_ QuotationDateValue)
        {
            writer.WriteStartElement(null, "QtnDt", xmlNamespace );
            QuotationDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PriceInformation20 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
