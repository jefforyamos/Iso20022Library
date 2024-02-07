﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BuyIn4.  ISO2002 ID# _7xh9US9WEeS94oXWDaBauA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies elements related to the notification (or warn) sent by the central counterparty to the clearing member in the context of the buy in process.
/// </summary>
public partial record BuyIn4
     : IIsoXmlSerilizable<BuyIn4>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the message is a warning only or a notification.
    /// </summary>
    public IsoYesNoIndicator? WarningIndicator { get; init; } 
    /// <summary>
    /// Provides the date at which the buy-in will occur.
    /// </summary>
    public required DateFormat15Choice_ ExpectedBuyInDate { get; init; } 
    /// <summary>
    /// Identifies the latest date by which the buy-in operation can be cancelled.
    /// </summary>
    public IsoISODate? CancellationLimitDate { get; init; } 
    /// <summary>
    /// Identifies the date by which the buy-in operation is reversed by the CCP.
    /// </summary>
    public IsoISODate? BuyInReversionDate { get; init; } 
    
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
        if (WarningIndicator is IsoYesNoIndicator WarningIndicatorValue)
        {
            writer.WriteStartElement(null, "WrngInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(WarningIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "XpctdBuyInDt", xmlNamespace );
        ExpectedBuyInDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CancellationLimitDate is IsoISODate CancellationLimitDateValue)
        {
            writer.WriteStartElement(null, "CxlLmtDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(CancellationLimitDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (BuyInReversionDate is IsoISODate BuyInReversionDateValue)
        {
            writer.WriteStartElement(null, "BuyInRvrsnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(BuyInReversionDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static BuyIn4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
