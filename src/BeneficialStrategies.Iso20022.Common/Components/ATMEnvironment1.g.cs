﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMEnvironment1.  ISO2002 ID# _hu8lkIn1EeS9F4Qrq_eaVA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the withdrawal transaction.
/// </summary>
public partial record ATMEnvironment1
     : IIsoXmlSerilizable<ATMEnvironment1>
{
    #nullable enable
    
    /// <summary>
    /// Acquirer of the withdrawal transaction, in charge of the funds settlement with the issuer.
    /// </summary>
    public Acquirer7? Acquirer { get; init; } 
    /// <summary>
    /// Identification of the ATM manager.
    /// </summary>
    public IsoMax35Text? ATMManagerIdentification { get; init; } 
    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    public TerminalHosting1? HostingEntity { get; init; } 
    /// <summary>
    /// ATM information.
    /// </summary>
    public required AutomatedTellerMachine1 ATM { get; init; } 
    /// <summary>
    /// Customer involved in the withdrawal transaction.
    /// </summary>
    public required ATMCustomer1 Customer { get; init; } 
    /// <summary>
    /// Card performing the withdrawal transaction.
    /// </summary>
    public PaymentCard16? Card { get; init; } 
    
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
        if (Acquirer is Acquirer7 AcquirerValue)
        {
            writer.WriteStartElement(null, "Acqrr", xmlNamespace );
            AcquirerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ATMManagerIdentification is IsoMax35Text ATMManagerIdentificationValue)
        {
            writer.WriteStartElement(null, "ATMMgrId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ATMManagerIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (HostingEntity is TerminalHosting1 HostingEntityValue)
        {
            writer.WriteStartElement(null, "HstgNtty", xmlNamespace );
            HostingEntityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ATM", xmlNamespace );
        ATM.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Cstmr", xmlNamespace );
        Customer.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Card is PaymentCard16 CardValue)
        {
            writer.WriteStartElement(null, "Card", xmlNamespace );
            CardValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ATMEnvironment1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
