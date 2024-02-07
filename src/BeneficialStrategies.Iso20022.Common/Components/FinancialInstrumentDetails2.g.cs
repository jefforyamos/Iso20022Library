﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentDetails2.  ISO2002 ID# _TxujO9p-Ed-ak6NoX_4Aeg_-1625514395.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reporting per financial instrument.
/// </summary>
public partial record FinancialInstrumentDetails2
     : IIsoXmlSerilizable<FinancialInstrumentDetails2>
{
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification11 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    public PriceInformation6? PriceDetails { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafekeepingPlaceFormat3Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    public OpeningBalance1? OpeningBalance { get; init; } 
    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    public ClosingBalance1? ClosingBalance { get; init; } 
    /// <summary>
    /// Transaction details.
    /// </summary>
    public Transaction6? Transaction { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _Tx4UNNp-Ed-ak6NoX_4Aeg_-1885617424
    
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
        writer.WriteStartElement(null, "FinInstrmId", xmlNamespace );
        FinancialInstrumentIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (PriceDetails is PriceInformation6 PriceDetailsValue)
        {
            writer.WriteStartElement(null, "PricDtls", xmlNamespace );
            PriceDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SafekeepingPlace is SafekeepingPlaceFormat3Choice_ SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OpeningBalance is OpeningBalance1 OpeningBalanceValue)
        {
            writer.WriteStartElement(null, "OpngBal", xmlNamespace );
            OpeningBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ClosingBalance is ClosingBalance1 ClosingBalanceValue)
        {
            writer.WriteStartElement(null, "ClsgBal", xmlNamespace );
            ClosingBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize Transaction, multiplicity Unknown
    }
    public static FinancialInstrumentDetails2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
