﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrument61.  ISO2002 ID# _FSZXoYfuEeevKP8c-ilVhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
public partial record FinancialInstrument61
     : IIsoXmlSerilizable<FinancialInstrument61>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    public required SecurityIdentification25Choice_ Identification { get; init; } 
    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    public IsoMax350Text? Name { get; init; } 
    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    public IsoMax35Text? ShortName { get; init; } 
    /// <summary>
    /// Specifies the quantity of assets to be transferred in units or in a percentage rate.
    /// </summary>
    public Quantity12Choice_? Quantity { get; init; } 
    /// <summary>
    /// Average cost per share of the security, including all fees.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; } 
    /// <summary>
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? TotalBookValue { get; init; } 
    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// </summary>
    public Account24? TransfereeAccount { get; init; } 
    /// <summary>
    /// Sub-account of the master or omnibus account.
    /// </summary>
    public SubAccount5? SubAccountDetails { get; init; } 
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    public PartyIdentificationAndAccount156? DeliveringAgentDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "Id", xmlNamespace );
        Identification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Name is IsoMax350Text NameValue)
        {
            writer.WriteStartElement(null, "Nm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(NameValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
        if (ShortName is IsoMax35Text ShortNameValue)
        {
            writer.WriteStartElement(null, "ShrtNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ShortNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (Quantity is Quantity12Choice_ QuantityValue)
        {
            writer.WriteStartElement(null, "Qty", xmlNamespace );
            QuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AverageAcquisitionPrice is IsoActiveOrHistoricCurrencyAndAmount AverageAcquisitionPriceValue)
        {
            writer.WriteStartElement(null, "AvrgAcqstnPric", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(AverageAcquisitionPriceValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TotalBookValue is IsoActiveOrHistoricCurrencyAndAmount TotalBookValueValue)
        {
            writer.WriteStartElement(null, "TtlBookVal", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(TotalBookValueValue)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TransfereeAccount is Account24 TransfereeAccountValue)
        {
            writer.WriteStartElement(null, "TrfeeAcct", xmlNamespace );
            TransfereeAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubAccountDetails is SubAccount5 SubAccountDetailsValue)
        {
            writer.WriteStartElement(null, "SubAcctDtls", xmlNamespace );
            SubAccountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveringAgentDetails is PartyIdentificationAndAccount156 DeliveringAgentDetailsValue)
        {
            writer.WriteStartElement(null, "DlvrgAgtDtls", xmlNamespace );
            DeliveringAgentDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static FinancialInstrument61 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
