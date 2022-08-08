namespace C_Sharp_Essential_Library;

public interface IMapper<S, T>
    {
    T Map(S source);
    }
