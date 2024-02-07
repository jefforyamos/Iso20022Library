﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMEnvironment10.  ISO2002 ID# _H12eUYtuEeSLQutgI1Ulfw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
public partial record ATMEnvironment10
     : IIsoXmlSerilizable<ATMEnvironment10>
{
    #nullable enable
    
    /// <summary>
    /// Acquirer of the ATM transaction, in charge of the funds settlement with the issuer.
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
    public required AutomatedTellerMachine8 ATM { get; init; } 
    
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
    }
    public static ATMEnvironment10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
