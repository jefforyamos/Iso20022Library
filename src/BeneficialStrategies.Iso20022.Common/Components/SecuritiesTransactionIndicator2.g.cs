﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesTransactionIndicator2.  ISO2002 ID# _ZVa-kGhoEeaqBY_HJicULw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional indicators on the transaction.
/// </summary>
public partial record SecuritiesTransactionIndicator2
     : IIsoXmlSerilizable<SecuritiesTransactionIndicator2>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the transaction was executed under a pre-trade waiver.
    /// </summary>
    public ReportingWaiverType1Code? WaiverIndicator { get; init; } 
    /// <summary>
    /// Indicates a short sell concluded by the investment agent on its own accounts or on behalf of a client, as described in the local regulation.
    /// </summary>
    public Side5Code? ShortSellingIndicator { get; init; } 
    /// <summary>
    /// Indicates the type of transaction in accordance with the local regulation.
    /// </summary>
    public ReportingWaiverType3Code? OTCPostTradeIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the transaction is objectively measurable as reducing risks directly relating to the commercial activity of the entity executing the transaction.
    /// </summary>
    public IsoTrueFalseIndicator? RiskReducingTransaction { get; init; } 
    /// <summary>
    /// Indicates whether the transaction falls within the scope of activity to be reported under the Securities Financing Transactions Regulation.
    /// </summary>
    public required IsoTrueFalseIndicator SecuritiesFinancingTransactionIndicator { get; init; } 
    
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
        if (WaiverIndicator is ReportingWaiverType1Code WaiverIndicatorValue)
        {
            writer.WriteStartElement(null, "WvrInd", xmlNamespace );
            writer.WriteValue(WaiverIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ShortSellingIndicator is Side5Code ShortSellingIndicatorValue)
        {
            writer.WriteStartElement(null, "ShrtSellgInd", xmlNamespace );
            writer.WriteValue(ShortSellingIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OTCPostTradeIndicator is ReportingWaiverType3Code OTCPostTradeIndicatorValue)
        {
            writer.WriteStartElement(null, "OTCPstTradInd", xmlNamespace );
            writer.WriteValue(OTCPostTradeIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (RiskReducingTransaction is IsoTrueFalseIndicator RiskReducingTransactionValue)
        {
            writer.WriteStartElement(null, "RskRdcgTx", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(RiskReducingTransactionValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctiesFincgTxInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(SecuritiesFinancingTransactionIndicator)); // data type TrueFalseIndicator System.String
        writer.WriteEndElement();
    }
    public static SecuritiesTransactionIndicator2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
