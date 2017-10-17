defmodule NumberConverterTest do
  use ExUnit.Case
  doctest NumberConverter

  test "0" do
    assert NumberConverter.to_words(0) == 'zero'
  end

  @tag :skip
  test "single digit (1 - 9)" do
    assert NumberConverter.to_words(1) == 'one'
    assert NumberConverter.to_words(9) == 'nine'
  end

  @tag :skip
  test "double digit under twenty (10 - 19)" do
    assert NumberConverter.to_words(10) == 'ten'
    assert NumberConverter.to_words(19) == 'nineteen'
  end

  @tag :skip
  test "multiples of ten (10, 50, 90)" do
    assert NumberConverter.to_words(20) == 'twenty'
    assert NumberConverter.to_words(90) == 'ninety'
  end

  @tag :skip
  test "not multiples of ten (21-99)" do
    assert NumberConverter.to_words(21) == 'twenty-one'
    assert NumberConverter.to_words(55) == 'fifty-five'
    assert NumberConverter.to_words(99) == 'ninety-nine'
  end

  @tag :skip
  test "hundreds (100, 500, 900)" do
    assert NumberConverter.to_words(100) == 'one hundred'
    assert NumberConverter.to_words(900) == 'nine hundred'
  end

  @tag :skip
  test "not multiples of one hundred (101-999)" do
    assert NumberConverter.to_words(101) == 'one hundred one'
    assert NumberConverter.to_words(999) == 'nine hundred ninety-nine'
  end

  @tag :skip
  test "thousands (1000, 5000, 9000)" do
    assert NumberConverter.to_words(1000) == 'one thousand'
    assert NumberConverter.to_words(9000) == 'nine thousand'
  end

  @tag :skip
  test "not even thousands (9999, 9911)" do
    assert NumberConverter.to_words(9999) == 'nine thousand nine hundred ninety-nine'
    assert NumberConverter.to_words(9911) == 'nine thousand nine hundred eleven'
  end

  @tag :skip
  test "tens of thousands (10,000, 19,000)" do
    assert NumberConverter.to_words(10000) == 'ten thousand'
    assert NumberConverter.to_words(19000) == 'nineteen thousand'
  end

  @tag :skip
  test "tens of thousands and some (19,999)" do
    assert NumberConverter.to_words(19999) == 'nineteen thousand nine hundred ninety-nine'
  end

  @tag :skip
  test "hundred thousand (100,000, 700,000)" do
    assert NumberConverter.to_words(100000) == 'one hundred thousand'
    assert NumberConverter.to_words(700000) == 'seven hundred thousand'
  end

  @tag :skip
  test "not exactly hundred thousand (198,000, 701,020)" do
    assert NumberConverter.to_words(198000) == 'one hundred ninety-eight thousand'
    assert NumberConverter.to_words(701020) == 'seven hundred one thousand twenty'
  end

  @tag :skip
  test "millions (1,000,000)" do
    assert NumberConverter.to_words(1000000) == 'one million'
  end
end
