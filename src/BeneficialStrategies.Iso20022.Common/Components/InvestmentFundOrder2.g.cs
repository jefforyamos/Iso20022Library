﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentFundOrder2.  ISO2002 ID# _TSlwINp-Ed-ak6NoX_4Aeg_-803507887.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reference of an order and of an order cancellation.
/// </summary>
public partial record InvestmentFundOrder2
     : IIsoXmlSerilizable<InvestmentFundOrder2>
{
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text OrderReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    public IsoMax35Text? DealReference { get; init; } 
    /// <summary>
    /// Account information of the individual order instruction or individual order cancellation request for which the status is requested.
    /// </summary>
    public InvestmentAccount13? InvestmentAccountDetails { get; init; } 
    /// <summary>
    /// Financial instrument information of the individual order or individual order cancellation request for which the status is requested.
    /// </summary>
    public FinancialInstrument10? FinancialInstrumentDetails { get; init; } 
    
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
        if (MasterReference is IsoMax35Text MasterReferenceValue)
        {
            writer.WriteStartElement(null, "MstrRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MasterReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "OrdrRef", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(OrderReference)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (ClientReference is IsoMax35Text ClientReferenceValue)
        {
            writer.WriteStartElement(null, "ClntRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ClientReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CancellationReference is IsoMax35Text CancellationReferenceValue)
        {
            writer.WriteStartElement(null, "CxlRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CancellationReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (DealReference is IsoMax35Text DealReferenceValue)
        {
            writer.WriteStartElement(null, "DealRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(DealReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (InvestmentAccountDetails is InvestmentAccount13 InvestmentAccountDetailsValue)
        {
            writer.WriteStartElement(null, "InvstmtAcctDtls", xmlNamespace );
            InvestmentAccountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FinancialInstrumentDetails is FinancialInstrument10 FinancialInstrumentDetailsValue)
        {
            writer.WriteStartElement(null, "FinInstrmDtls", xmlNamespace );
            FinancialInstrumentDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static InvestmentFundOrder2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
