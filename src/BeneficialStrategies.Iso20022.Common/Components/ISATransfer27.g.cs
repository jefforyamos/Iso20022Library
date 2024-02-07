﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ISATransfer27.  ISO2002 ID# _PQwjESYhEeW_ZNn8gbfY7Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the type of product and the assets to be transferred.
/// </summary>
public partial record ISATransfer27
     : IIsoXmlSerilizable<ISATransfer27>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Identification assigned to the transfer of asset, typically assigned by the transferee.
    /// </summary>
    public required IsoMax35Text TransferIdentification { get; init; } 
    /// <summary>
    /// Specifies portfolio information or government schemes, for example Individual Savings Account (ISA) in the UK.
    /// </summary>
    public ISAPortfolio3Choice_? Portfolio { get; init; } 
    /// <summary>
    /// Specifies whether all remaining assets in a portfolio not listed for transfer should be liquidated and transferred as cash.
    /// </summary>
    public AllOtherCash1Code? AllOtherCash { get; init; } 
    /// <summary>
    /// Specifies the underlying assets for the ISA or portfolio.
    /// </summary>
    public FinancialInstrument50? FinancialInstrumentAssetForTransfer { get; init; } 
    
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
        writer.WriteStartElement(null, "TrfId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(TransferIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (Portfolio is ISAPortfolio3Choice_ PortfolioValue)
        {
            writer.WriteStartElement(null, "Prtfl", xmlNamespace );
            PortfolioValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AllOtherCash is AllOtherCash1Code AllOtherCashValue)
        {
            writer.WriteStartElement(null, "AllOthrCsh", xmlNamespace );
            writer.WriteValue(AllOtherCashValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (FinancialInstrumentAssetForTransfer is FinancialInstrument50 FinancialInstrumentAssetForTransferValue)
        {
            writer.WriteStartElement(null, "FinInstrmAsstForTrf", xmlNamespace );
            FinancialInstrumentAssetForTransferValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ISATransfer27 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
