﻿namespace RailMapGenerator {
    public class Pair<T1, T2> {
        public T1 first;
        public T2 second;

        public Pair(T1 item1, T2 item2) {
            this.first = item1;
            this.second = item2;
        }
    }
}