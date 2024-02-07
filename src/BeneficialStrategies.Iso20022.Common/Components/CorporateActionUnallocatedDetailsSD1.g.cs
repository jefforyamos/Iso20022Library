﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionUnallocatedDetailsSD1.  ISO2002 ID# _1YlrQDL3EeKU9IrkkToqcw_1723135962.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding the corporate action event.
/// </summary>
public partial record CorporateActionUnallocatedDetailsSD1
     : IIsoXmlSerilizable<CorporateActionUnallocatedDetailsSD1>
{
    #nullable enable
    
    /// <summary>
    /// Account where financial instruments are maintained.
    /// </summary>
    public required IsoRestrictedFINXMax35Text SafekeepingAccount { get; init; } 
    /// <summary>
    /// Type of Participants positions balance concerned in unallocated payment.
    /// </summary>
    public CorporateActionUnallocatedBalanceSD1Choice_? UnallocatedBalance { get; init; } 
    /// <summary>
    /// Details of the securities transactions concerned in unallocated payment.
    /// </summary>
    public CorporateActionUnallocatedSecuritiesTransactionDetailsSD1? UnallocatedSecuritiesTransactionDetails { get; init; } 
    /// <summary>
    /// Details of the cash transactions concerned in unallocated payment.
    /// </summary>
    public CorporateActionUnallocatedCashTransactionDetailsSD1? UnallocatedCashTransactionDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax35Text(SafekeepingAccount)); // data type RestrictedFINXMax35Text System.String
        writer.WriteEndElement();
        if (UnallocatedBalance is CorporateActionUnallocatedBalanceSD1Choice_ UnallocatedBalanceValue)
        {
            writer.WriteStartElement(null, "UallctdBal", xmlNamespace );
            UnallocatedBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnallocatedSecuritiesTransactionDetails is CorporateActionUnallocatedSecuritiesTransactionDetailsSD1 UnallocatedSecuritiesTransactionDetailsValue)
        {
            writer.WriteStartElement(null, "UallctdSctiesTxDtls", xmlNamespace );
            UnallocatedSecuritiesTransactionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnallocatedCashTransactionDetails is CorporateActionUnallocatedCashTransactionDetailsSD1 UnallocatedCashTransactionDetailsValue)
        {
            writer.WriteStartElement(null, "UallctdCshTxDtls", xmlNamespace );
            UnallocatedCashTransactionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionUnallocatedDetailsSD1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
