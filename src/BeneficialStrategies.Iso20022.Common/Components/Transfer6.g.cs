﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transfer6.  ISO2002 ID# _QWFix9p-Ed-ak6NoX_4Aeg_1970934247.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
public partial record Transfer6
     : IIsoXmlSerilizable<Transfer6>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    public IsoMax35Text? MasterReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
    /// </summary>
    public required IsoMax35Text TransferReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    public IsoMax35Text? CancellationReference { get; init; } 
    /// <summary>
    /// Date at which the instructing party places the transfer instruction.
    /// </summary>
    public DateFormat1Choice_? TransferDate { get; init; } 
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; } 
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "TrfRef", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(TransferReference)); // data type Max35Text System.String
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
        if (TransferDate is DateFormat1Choice_ TransferDateValue)
        {
            writer.WriteStartElement(null, "TrfDt", xmlNamespace );
            TransferDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TtlUnitsNb", xmlNamespace );
        TotalUnitsNumber.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OwnAccountTransferIndicator is IsoYesNoIndicator OwnAccountTransferIndicatorValue)
        {
            writer.WriteStartElement(null, "OwnAcctTrfInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(OwnAccountTransferIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (NonStandardSettlementInformation is IsoMax350Text NonStandardSettlementInformationValue)
        {
            writer.WriteStartElement(null, "NonStdSttlmInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax350Text(NonStandardSettlementInformationValue)); // data type Max350Text System.String
            writer.WriteEndElement();
        }
    }
    public static Transfer6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
