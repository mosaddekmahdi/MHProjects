/**
 * HiThereServiceLocator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.arpit.javapostforlearning.webservices;

public class HiThereServiceLocator extends org.apache.axis.client.Service implements org.arpit.javapostforlearning.webservices.HiThereService {

    public HiThereServiceLocator() {
    }


    public HiThereServiceLocator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public HiThereServiceLocator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for HiThere
    private java.lang.String HiThere_address = "http://localhost:8080/SimpleSOAPExample/services/HiThere";

    public java.lang.String getHiThereAddress() {
        return HiThere_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String HiThereWSDDServiceName = "HiThere";

    public java.lang.String getHiThereWSDDServiceName() {
        return HiThereWSDDServiceName;
    }

    public void setHiThereWSDDServiceName(java.lang.String name) {
        HiThereWSDDServiceName = name;
    }

    public org.arpit.javapostforlearning.webservices.HiThere getHiThere() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(HiThere_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getHiThere(endpoint);
    }

    public org.arpit.javapostforlearning.webservices.HiThere getHiThere(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            org.arpit.javapostforlearning.webservices.HiThereSoapBindingStub _stub = new org.arpit.javapostforlearning.webservices.HiThereSoapBindingStub(portAddress, this);
            _stub.setPortName(getHiThereWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setHiThereEndpointAddress(java.lang.String address) {
        HiThere_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (org.arpit.javapostforlearning.webservices.HiThere.class.isAssignableFrom(serviceEndpointInterface)) {
                org.arpit.javapostforlearning.webservices.HiThereSoapBindingStub _stub = new org.arpit.javapostforlearning.webservices.HiThereSoapBindingStub(new java.net.URL(HiThere_address), this);
                _stub.setPortName(getHiThereWSDDServiceName());
                return _stub;
            }
        }
        catch (java.lang.Throwable t) {
            throw new javax.xml.rpc.ServiceException(t);
        }
        throw new javax.xml.rpc.ServiceException("There is no stub implementation for the interface:  " + (serviceEndpointInterface == null ? "null" : serviceEndpointInterface.getName()));
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(javax.xml.namespace.QName portName, Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        if (portName == null) {
            return getPort(serviceEndpointInterface);
        }
        java.lang.String inputPortName = portName.getLocalPart();
        if ("HiThere".equals(inputPortName)) {
            return getHiThere();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://webservices.javapostforlearning.arpit.org", "HiThereService");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://webservices.javapostforlearning.arpit.org", "HiThere"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("HiThere".equals(portName)) {
            setHiThereEndpointAddress(address);
        }
        else 
{ // Unknown Port Name
            throw new javax.xml.rpc.ServiceException(" Cannot set Endpoint Address for Unknown Port" + portName);
        }
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(javax.xml.namespace.QName portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        setEndpointAddress(portName.getLocalPart(), address);
    }

}
