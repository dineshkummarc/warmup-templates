namespace __NAME__.infrastructure.logging
{
    using System;

    public interface LogFactory
    {
        Logger create_logger_bound_to(Object type);
    }
}