﻿namespace Iterator.Interface;

public interface IIterator<T> 
{
    bool HasNext();
    T Next();
}