/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.8
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiTexel : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiTexel(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiTexel obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiTexel() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AssimpPINVOKE.delete_aiTexel(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public byte b {
    set {
      AssimpPINVOKE.aiTexel_b_set(swigCPtr, value);
    } 
    get {
      byte ret = AssimpPINVOKE.aiTexel_b_get(swigCPtr);
      return ret;
    } 
  }

  public byte g {
    set {
      AssimpPINVOKE.aiTexel_g_set(swigCPtr, value);
    } 
    get {
      byte ret = AssimpPINVOKE.aiTexel_g_get(swigCPtr);
      return ret;
    } 
  }

  public byte r {
    set {
      AssimpPINVOKE.aiTexel_r_set(swigCPtr, value);
    } 
    get {
      byte ret = AssimpPINVOKE.aiTexel_r_get(swigCPtr);
      return ret;
    } 
  }

  public byte a {
    set {
      AssimpPINVOKE.aiTexel_a_set(swigCPtr, value);
    } 
    get {
      byte ret = AssimpPINVOKE.aiTexel_a_get(swigCPtr);
      return ret;
    } 
  }

  public bool __equal__(aiTexel other) {
    bool ret = AssimpPINVOKE.aiTexel___equal__(swigCPtr, aiTexel.getCPtr(other));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool __nequal__(aiTexel other) {
    bool ret = AssimpPINVOKE.aiTexel___nequal__(swigCPtr, aiTexel.getCPtr(other));
    if (AssimpPINVOKE.SWIGPendingException.Pending) throw AssimpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiTexel() : this(AssimpPINVOKE.new_aiTexel(), true) {
  }

}
